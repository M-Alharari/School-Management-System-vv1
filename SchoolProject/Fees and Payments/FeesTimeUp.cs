using SchoolProjectBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject.Fees_and_Payments
{
    public partial class FeesTimeUp : Form
    {
        private readonly List<int> _tuitionFeeIDs;
        public FeesTimeUp(List<int> tuitionFeeIDs)
        {
            InitializeComponent(); _tuitionFeeIDs = tuitionFeeIDs;
            this.Load += FeesTimeUp_Load;
            //dgvDueInstallments.CellContentClick += dgvDueInstallments_CellContentClick;
            dgvDueInstallments.CellClick += dgvDueInstallments_CellClick;
        }

        private void FeesTimeUp_Load(object sender, EventArgs e)
        {
            LoadDueInstallments();
        }

        private void LoadDueInstallments()
        {
            try
            {
                DataTable dtFinal = new DataTable();
               
                dtFinal.Columns.Add("InstallmentID", typeof(int));
                dtFinal.Columns.Add("Installment#", typeof(int));
                dtFinal.Columns.Add("Student Name", typeof(string));
                dtFinal.Columns.Add("TuitionID", typeof(int));
                dtFinal.Columns.Add("Due Date", typeof(string));
                dtFinal.Columns.Add("Amount", typeof(decimal));

                foreach (int tuitionFeeID in _tuitionFeeIDs)
                {
                    DataTable dt = clsInstallment.GetInstallmentSummaryByTuitionFeeID2(tuitionFeeID);

                    var dueRows = dt.AsEnumerable()
                        .Where(r => !Convert.ToBoolean(r["IsPaid"]) &&
                                    Convert.ToDateTime(r["DueDate"]) <= DateTime.Today)
                        .ToList();

                    foreach (var row in dueRows)
                    {
                        dtFinal.Rows.Add(                    
                            row["InstallmentID"],
                            row["InstallmentNumber"],
                            row["FullName"],
                            tuitionFeeID,
                            Convert.ToDateTime(row["DueDate"]).ToShortDateString(),
                            row["Amount"]
                        );
                    }
                }

                if (dtFinal.Rows.Count == 0)
                {
                    MessageBox.Show("No due installments found.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDueInstallments.DataSource = null;
                    return;
                }

                dgvDueInstallments.DataSource = dtFinal;
                lblRecordCount.Text = dgvDueInstallments.Rows.Count.ToString();
                dgvDueInstallments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // ✅ Hide the TuitionID column (but keep it accessible in code)
                dgvDueInstallments.Columns["TuitionID"].Visible = false;

                // Add Pay button column if not already added
                if (!dgvDueInstallments.Columns.Contains("Pay"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
                    {
                        HeaderText = "Action",
                        Text = "Pay",
                        Name = "Pay",
                        UseColumnTextForButtonValue = true,
                        Width = 80
                    };
                    dgvDueInstallments.Columns.Add(btnCol);
                }

                // Make all other columns read-only
                foreach (DataGridViewColumn col in dgvDueInstallments.Columns)
                {
                    if (col.Name != "Pay")
                        col.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading installments: " + ex.Message);
            }
        }
        private void dgvDueInstallments_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Check if user clicked the "Pay" button column
            if (dgvDueInstallments.Columns[e.ColumnIndex].Name == "Pay")
            {
                // Prevent accidental double-triggers
                dgvDueInstallments.ClearSelection();

                int installmentID = Convert.ToInt32(dgvDueInstallments.Rows[e.RowIndex].Cells["InstallmentID"].Value);

                using (var payForm = new frmPayInstallment(installmentID))
                {
                    var result = payForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("Payment completed successfully.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDueInstallments();
                    }
                }

                // ✅ Force focus away from button cell to stop re-trigger after modal close
                this.ActiveControl = null;
            }
        }
        private void RefreshInstallments()
        {
            // Reload installments from DB
            LoadDueInstallments();

           
        }

        private void UpdatePayButtons()
        {
            foreach (DataGridViewRow row in dgvDueInstallments.Rows)
            {
                // only update if the column exists
                if (!dgvDueInstallments.Columns.Contains("Pay"))
                    continue;

                bool isPaid = row.Cells["Due Date"].Value == null ? false : false; // placeholder
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)row.Cells["Pay"];

                // You can later add an IsPaid column if needed
                buttonCell.Value = "Pay";
                buttonCell.ReadOnly = false;
                buttonCell.Style.ForeColor = Color.Black;
            }
        }

        private void dgvDueInstallments_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvDueInstallments.Columns[e.ColumnIndex].Name == "Pay")
            {
                // Clear selection before opening form
                dgvDueInstallments.ClearSelection();

                int installmentID = Convert.ToInt32(dgvDueInstallments.Rows[e.RowIndex].Cells["InstallmentID"].Value);

                using (var payForm = new frmPayInstallment(installmentID))
                {
                    var result = payForm.ShowDialog();
                    if (result == DialogResult.OK || result == DialogResult.Cancel)
                    {
                        RefreshInstallments();
                    }
                }

                // Clear any potential focus
                dgvDueInstallments.CurrentCell = null;
            }
        }
        private bool _isOpeningPayForm = false;
        private void dgvDueInstallments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvDueInstallments.Columns[e.ColumnIndex].Name == "Pay")
            {
                // Clear selection immediately
                dgvDueInstallments.ClearSelection();
                dgvDueInstallments.CurrentCell = null;

                int installmentID = Convert.ToInt32(dgvDueInstallments.Rows[e.RowIndex].Cells["InstallmentID"].Value);

                using (var payForm = new frmPayInstallment(installmentID))
                {
                    payForm.ShowDialog();
                    RefreshInstallments();
                }

                // Force refresh of the button cell
                dgvDueInstallments.InvalidateCell(e.ColumnIndex, e.RowIndex);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
