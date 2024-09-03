
namespace bosssystem1
{
    partial class invform
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.partsTableTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.PartsTableTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.daterectxt = new System.Windows.Forms.MaskedTextBox();
            this.updatepartbtn = new System.Windows.Forms.Button();
            this.addpartbtn = new System.Windows.Forms.Button();
            this.suppidtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vattxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itempricetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.itemquantxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.itemdesctxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partnotxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(143, 53);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(225, 22);
            this.searchBar.TabIndex = 1;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Part Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNoDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.dateReceivedDataGridViewTextBoxColumn,
            this.itemVatDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 241);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            this.itemQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateReceivedDataGridViewTextBoxColumn
            // 
            this.dateReceivedDataGridViewTextBoxColumn.DataPropertyName = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn.HeaderText = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateReceivedDataGridViewTextBoxColumn.Name = "dateReceivedDataGridViewTextBoxColumn";
            this.dateReceivedDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemVatDataGridViewTextBoxColumn
            // 
            this.itemVatDataGridViewTextBoxColumn.DataPropertyName = "ItemVat";
            this.itemVatDataGridViewTextBoxColumn.HeaderText = "ItemVat";
            this.itemVatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemVatDataGridViewTextBoxColumn.Name = "itemVatDataGridViewTextBoxColumn";
            this.itemVatDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // partsTableBindingSource
            // 
            this.partsTableBindingSource.DataMember = "PartsTable";
            this.partsTableBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsTableTableAdapter
            // 
            this.partsTableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.daterectxt);
            this.groupBox1.Controls.Add(this.updatepartbtn);
            this.groupBox1.Controls.Add(this.addpartbtn);
            this.groupBox1.Controls.Add(this.suppidtxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.vattxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.itempricetxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.itemquantxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.itemnametxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.itemdesctxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.partnotxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Part";
            // 
            // daterectxt
            // 
            this.daterectxt.Location = new System.Drawing.Point(437, 122);
            this.daterectxt.Mask = "0000/00/00";
            this.daterectxt.Name = "daterectxt";
            this.daterectxt.Size = new System.Drawing.Size(177, 22);
            this.daterectxt.TabIndex = 17;
            this.daterectxt.ValidatingType = typeof(System.DateTime);
            // 
            // updatepartbtn
            // 
            this.updatepartbtn.Location = new System.Drawing.Point(814, 171);
            this.updatepartbtn.Name = "updatepartbtn";
            this.updatepartbtn.Size = new System.Drawing.Size(149, 41);
            this.updatepartbtn.TabIndex = 7;
            this.updatepartbtn.Text = "Update Parts";
            this.updatepartbtn.UseVisualStyleBackColor = true;
            this.updatepartbtn.Click += new System.EventHandler(this.updatepartbtn_Click);
            // 
            // addpartbtn
            // 
            this.addpartbtn.Location = new System.Drawing.Point(569, 171);
            this.addpartbtn.Name = "addpartbtn";
            this.addpartbtn.Size = new System.Drawing.Size(188, 45);
            this.addpartbtn.TabIndex = 16;
            this.addpartbtn.Text = "Add Part";
            this.addpartbtn.UseVisualStyleBackColor = true;
            this.addpartbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // suppidtxt
            // 
            this.suppidtxt.Location = new System.Drawing.Point(1074, 119);
            this.suppidtxt.Name = "suppidtxt";
            this.suppidtxt.Size = new System.Drawing.Size(178, 22);
            this.suppidtxt.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(995, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "SupplierID";
            // 
            // vattxt
            // 
            this.vattxt.Location = new System.Drawing.Point(773, 119);
            this.vattxt.Name = "vattxt";
            this.vattxt.Size = new System.Drawing.Size(178, 22);
            this.vattxt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(708, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Item Vat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date Received";
            // 
            // itempricetxt
            // 
            this.itempricetxt.Location = new System.Drawing.Point(100, 119);
            this.itempricetxt.Name = "itempricetxt";
            this.itempricetxt.Size = new System.Drawing.Size(178, 22);
            this.itempricetxt.TabIndex = 9;
            this.itempricetxt.TextChanged += new System.EventHandler(this.itempricetxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // itemquantxt
            // 
            this.itemquantxt.Location = new System.Drawing.Point(1074, 52);
            this.itemquantxt.Name = "itemquantxt";
            this.itemquantxt.Size = new System.Drawing.Size(178, 22);
            this.itemquantxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(977, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Item Quantity";
            // 
            // itemnametxt
            // 
            this.itemnametxt.Location = new System.Drawing.Point(773, 52);
            this.itemnametxt.Name = "itemnametxt";
            this.itemnametxt.Size = new System.Drawing.Size(178, 22);
            this.itemnametxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Name";
            // 
            // itemdesctxt
            // 
            this.itemdesctxt.Location = new System.Drawing.Point(436, 52);
            this.itemdesctxt.Name = "itemdesctxt";
            this.itemdesctxt.Size = new System.Drawing.Size(178, 22);
            this.itemdesctxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Description";
            // 
            // partnotxt
            // 
            this.partnotxt.Location = new System.Drawing.Point(100, 52);
            this.partnotxt.Name = "partnotxt";
            this.partnotxt.Size = new System.Drawing.Size(178, 22);
            this.partnotxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "PartNo";
            // 
            // invform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Name = "invform";
            this.Text = "invform";
            this.Load += new System.EventHandler(this.invform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource partsTableBindingSource;
        private G13Wst2024DataSetTableAdapters.PartsTableTableAdapter partsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addpartbtn;
        private System.Windows.Forms.TextBox suppidtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vattxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox itempricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemquantxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemnametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemdesctxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partnotxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox daterectxt;
        private System.Windows.Forms.Button updatepartbtn;
    }
}