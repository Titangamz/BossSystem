
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
            this.invgrid = new System.Windows.Forms.DataGridView();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addpartbtn = new System.Windows.Forms.Button();
            this.partsTableTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.PartsTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.invgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // invgrid
            // 
            this.invgrid.AutoGenerateColumns = false;
            this.invgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNoDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn});
            this.invgrid.DataSource = this.partsTableBindingSource;
            this.invgrid.Location = new System.Drawing.Point(12, 90);
            this.invgrid.Name = "invgrid";
            this.invgrid.ReadOnly = true;
            this.invgrid.RowHeadersWidth = 51;
            this.invgrid.RowTemplate.Height = 24;
            this.invgrid.Size = new System.Drawing.Size(1312, 229);
            this.invgrid.TabIndex = 0;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.partNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            this.itemQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemPriceDataGridViewTextBoxColumn.Width = 125;
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
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(143, 53);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(225, 22);
            this.searchBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Customer ";
            // 
            // addpartbtn
            // 
            this.addpartbtn.Location = new System.Drawing.Point(609, 536);
            this.addpartbtn.Name = "addpartbtn";
            this.addpartbtn.Size = new System.Drawing.Size(152, 42);
            this.addpartbtn.TabIndex = 3;
            this.addpartbtn.Text = "Add Part";
            this.addpartbtn.UseVisualStyleBackColor = true;
            // 
            // partsTableTableAdapter
            // 
            this.partsTableTableAdapter.ClearBeforeFill = true;
            // 
            // invform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 590);
            this.Controls.Add(this.addpartbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.invgrid);
            this.Name = "invform";
            this.Text = "invform";
            this.Load += new System.EventHandler(this.invform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invgrid;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addpartbtn;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource partsTableBindingSource;
        private G13Wst2024DataSetTableAdapters.PartsTableTableAdapter partsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
    }
}