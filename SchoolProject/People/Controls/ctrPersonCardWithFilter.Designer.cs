namespace SchoolProject.People.Controls
{
    partial class ctrPersonCardWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrPersonCardWithFilter));
            gbFilters = new GroupBox();
            btnAddNewPerson = new Button();
            btnFind = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            personcard1 = new ctrlPersonCard();
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnAddNewPerson);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(cbFilterBy);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.Location = new Point(5, 3);
            gbFilters.Margin = new Padding(4, 3, 4, 3);
            gbFilters.Name = "gbFilters";
            gbFilters.Padding = new Padding(4, 3, 4, 3);
            gbFilters.Size = new Size(642, 63);
            gbFilters.TabIndex = 18;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.FlatStyle = FlatStyle.Flat;
            btnAddNewPerson.Image = (Image)resources.GetObject("btnAddNewPerson.Image");
            btnAddNewPerson.Location = new Point(592, 17);
            btnAddNewPerson.Margin = new Padding(4, 3, 4, 3);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(35, 33);
            btnAddNewPerson.TabIndex = 20;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_Click;
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.Location = new Point(549, 17);
            btnFind.Margin = new Padding(4, 3, 4, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(35, 33);
            btnFind.TabIndex = 18;
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click_1;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "Person ID", "National No." });
            cbFilterBy.Location = new Point(117, 19);
            cbFilterBy.Margin = new Padding(4, 3, 4, 3);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(180, 28);
            cbFilterBy.TabIndex = 16;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.Location = new Point(306, 19);
            txtFilterValue.Margin = new Padding(5, 6, 5, 6);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(234, 29);
            txtFilterValue.TabIndex = 17;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 23);
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
            // personcard1
            // 
            personcard1.BackColor = Color.White;
            personcard1.Location = new Point(0, 72);
            personcard1.Margin = new Padding(5, 3, 5, 3);
            personcard1.Name = "personcard1";
            personcard1.Size = new Size(647, 308);
            personcard1.TabIndex = 19;
            // 
            // ctrPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(personcard1);
            Controls.Add(gbFilters);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ctrPersonCardWithFilter";
            Size = new Size(650, 381);
            Load += ctrPersonCardWithFilter_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private ctrlPersonCard personcard1;
        private System.Windows.Forms.Button btnAddNewPerson;
    }
}
