
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
            this.invgrid = new System.Windows.Forms.DataGridView();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addpartbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // invgrid
            // 
            this.invgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invgrid.Location = new System.Drawing.Point(12, 90);
            this.invgrid.Name = "invgrid";
            this.invgrid.RowHeadersWidth = 51;
            this.invgrid.RowTemplate.Height = 24;
            this.invgrid.Size = new System.Drawing.Size(775, 229);
            this.invgrid.TabIndex = 0;
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(143, 53);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(172, 22);
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
            this.addpartbtn.Location = new System.Drawing.Point(301, 362);
            this.addpartbtn.Name = "addpartbtn";
            this.addpartbtn.Size = new System.Drawing.Size(152, 42);
            this.addpartbtn.TabIndex = 3;
            this.addpartbtn.Text = "Add Part";
            this.addpartbtn.UseVisualStyleBackColor = true;
            // 
            // invform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addpartbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.invgrid);
            this.Name = "invform";
            this.Text = "invform";
            this.Load += new System.EventHandler(this.invform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invgrid;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addpartbtn;
    }
}