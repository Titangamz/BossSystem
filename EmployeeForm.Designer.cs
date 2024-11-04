
namespace bosssystem1
{
    partial class EmployeeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.employeeTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.EmployeeTableAdapter();
            this.updatebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.emppasstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empsurtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empmailtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empnumtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.empidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.employeeSurnameDataGridViewTextBoxColumn,
            this.employeePhoneNumberDataGridViewTextBoxColumn,
            this.employeeEmailDataGridViewTextBoxColumn,
            this.employeePasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1251, 175);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(1115, 376);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(133, 58);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Update Employee Table";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.emppasstxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.empsurtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.empmailtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.empnametxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.empnumtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.empidtxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 175);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Employee";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emppasstxt
            // 
            this.emppasstxt.Location = new System.Drawing.Point(723, 115);
            this.emppasstxt.Name = "emppasstxt";
            this.emppasstxt.Size = new System.Drawing.Size(144, 22);
            this.emppasstxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee Password";
            // 
            // empsurtxt
            // 
            this.empsurtxt.Location = new System.Drawing.Point(723, 41);
            this.empsurtxt.Name = "empsurtxt";
            this.empsurtxt.Size = new System.Drawing.Size(144, 22);
            this.empsurtxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee Surname:";
            // 
            // empmailtxt
            // 
            this.empmailtxt.Location = new System.Drawing.Point(417, 115);
            this.empmailtxt.Name = "empmailtxt";
            this.empmailtxt.Size = new System.Drawing.Size(144, 22);
            this.empmailtxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee Email";
            // 
            // empnametxt
            // 
            this.empnametxt.Location = new System.Drawing.Point(389, 44);
            this.empnametxt.Name = "empnametxt";
            this.empnametxt.Size = new System.Drawing.Size(144, 22);
            this.empnametxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name:";
            // 
            // empnumtxt
            // 
            this.empnumtxt.Location = new System.Drawing.Point(126, 115);
            this.empnumtxt.Name = "empnumtxt";
            this.empnumtxt.Size = new System.Drawing.Size(144, 22);
            this.empnumtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // empidtxt
            // 
            this.empidtxt.Location = new System.Drawing.Point(102, 44);
            this.empidtxt.Name = "empidtxt";
            this.empidtxt.Size = new System.Drawing.Size(144, 22);
            this.empidtxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmployeeID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1269, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "If you wish to change any data simply edit the table and click update";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 40);
            this.label7.TabIndex = 4;
            this.label7.Text = "EMPLOYEES";
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            this.employeeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeSurnameDataGridViewTextBoxColumn
            // 
            this.employeeSurnameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeSurname";
            this.employeeSurnameDataGridViewTextBoxColumn.HeaderText = "EmployeeSurname";
            this.employeeSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeSurnameDataGridViewTextBoxColumn.Name = "employeeSurnameDataGridViewTextBoxColumn";
            this.employeeSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeePhoneNumberDataGridViewTextBoxColumn
            // 
            this.employeePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "EmployeePhoneNumber";
            this.employeePhoneNumberDataGridViewTextBoxColumn.HeaderText = "EmployeePhoneNumber";
            this.employeePhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeePhoneNumberDataGridViewTextBoxColumn.Name = "employeePhoneNumberDataGridViewTextBoxColumn";
            this.employeePhoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeEmailDataGridViewTextBoxColumn
            // 
            this.employeeEmailDataGridViewTextBoxColumn.DataPropertyName = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.HeaderText = "EmployeeEmail";
            this.employeeEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeEmailDataGridViewTextBoxColumn.Name = "employeeEmailDataGridViewTextBoxColumn";
            this.employeeEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeePasswordDataGridViewTextBoxColumn
            // 
            this.employeePasswordDataGridViewTextBoxColumn.DataPropertyName = "EmployeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.HeaderText = "EmployeePassword";
            this.employeePasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeePasswordDataGridViewTextBoxColumn.Name = "employeePasswordDataGridViewTextBoxColumn";
            this.employeePasswordDataGridViewTextBoxColumn.Visible = false;
            this.employeePasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 572);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updatebtn);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private G13Wst2024DataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox empmailtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empnumtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox emppasstxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empsurtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePasswordDataGridViewTextBoxColumn;
    }
}