namespace SchoolProject.Employees
{
    partial class ctrlEmployeeCardWithFilter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlEmployeeCardWithFilter));
            gbFilters = new GroupBox();
            btnFind = new Button();
            btnAddNewEmployee = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ctrlEmployeeCard1 = new ctrlEmployeeCard();
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(btnAddNewEmployee);
            gbFilters.Controls.Add(cbFilterBy);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbFilters.Location = new Point(5, 3);
            gbFilters.Margin = new Padding(4, 3, 4, 3);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(4, 3, 4, 3);
            gbFilters.Size = new Size(742, 65);
            gbFilters.TabIndex = 20;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.Popup;
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.Location = new Point(608, 17);
            btnFind.Margin = new Padding(5, 6, 5, 6);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(41, 39);
            btnFind.TabIndex = 20;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnAddNewEmployee
            // 
            btnAddNewEmployee.FlatStyle = FlatStyle.Flat;
            btnAddNewEmployee.Image = (Image)resources.GetObject("btnAddNewEmployee.Image");
            btnAddNewEmployee.Location = new Point(658, 18);
            btnAddNewEmployee.Margin = new Padding(4, 3, 4, 3);
            btnAddNewEmployee.Name = "btnAddNewEmployee";
            btnAddNewEmployee.Size = new Size(42, 38);
            btnAddNewEmployee.TabIndex = 18;
            btnAddNewEmployee.UseVisualStyleBackColor = true;
            btnAddNewEmployee.Click += btnAddNewEmployee_Click;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "Employee ID" });
            cbFilterBy.Location = new Point(102, 21);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(238, 28);
            cbFilterBy.Sorted = true;
            cbFilterBy.TabIndex = 16;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(355, 21);
            txtFilterValue.Margin = new Padding(5, 6, 5, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(243, 29);
            txtFilterValue.TabIndex = 17;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 19;
            label1.Text = "Find By:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // ctrlEmployeeCard1
            // 
            ctrlEmployeeCard1.BackColor = Color.White;
            ctrlEmployeeCard1.BackgroundImageLayout = ImageLayout.Center;
            ctrlEmployeeCard1.Location = new Point(0, 68);
            ctrlEmployeeCard1.Margin = new Padding(5, 3, 5, 3);
            ctrlEmployeeCard1.Name = "ctrlEmployeeCard1";
            ctrlEmployeeCard1.Size = new Size(747, 301);
            ctrlEmployeeCard1.TabIndex = 21;
            // 
            // ctrlEmployeeCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ctrlEmployeeCard1);
            Controls.Add(gbFilters);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ctrlEmployeeCardWithFilter";
            Size = new Size(750, 368);
            Load += ctrlEmployeeCardWithFilter_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnAddNewEmployee;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrlEmployeeCard ctrlEmployeeCard1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
