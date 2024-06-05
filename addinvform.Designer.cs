
namespace bosssystem1
{
    partial class addinvform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.parttxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.incertpartbtn = new System.Windows.Forms.Button();
            this.partsTableTableAdapter1 = new bosssystem1.G13Wst2024DataSetTableAdapters.PartsTableTableAdapter();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.quantxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD INVENTORY ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Part Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Part Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Part Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantxt);
            this.groupBox1.Controls.Add(this.pricetxt);
            this.groupBox1.Controls.Add(this.desctxt);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.parttxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(15, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 327);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add all of the details for the new part";
            // 
            // parttxt
            // 
            this.parttxt.Location = new System.Drawing.Point(206, 53);
            this.parttxt.Name = "parttxt";
            this.parttxt.Size = new System.Drawing.Size(190, 22);
            this.parttxt.TabIndex = 10;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(206, 148);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(190, 22);
            this.nametxt.TabIndex = 11;
            // 
            // desctxt
            // 
            this.desctxt.Location = new System.Drawing.Point(822, 53);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(190, 22);
            this.desctxt.TabIndex = 12;
            // 
            // incertpartbtn
            // 
            this.incertpartbtn.Location = new System.Drawing.Point(537, 476);
            this.incertpartbtn.Name = "incertpartbtn";
            this.incertpartbtn.Size = new System.Drawing.Size(188, 57);
            this.incertpartbtn.TabIndex = 12;
            this.incertpartbtn.Text = "Add Part To Database";
            this.incertpartbtn.UseVisualStyleBackColor = true;
            this.incertpartbtn.Click += new System.EventHandler(this.incertpartbtn_Click);
            // 
            // partsTableTableAdapter1
            // 
            this.partsTableTableAdapter1.ClearBeforeFill = true;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(206, 241);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(190, 22);
            this.pricetxt.TabIndex = 13;
            // 
            // quantxt
            // 
            this.quantxt.Location = new System.Drawing.Point(822, 148);
            this.quantxt.Name = "quantxt";
            this.quantxt.Size = new System.Drawing.Size(190, 22);
            this.quantxt.TabIndex = 14;
            // 
            // addinvform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 590);
            this.Controls.Add(this.incertpartbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "addinvform";
            this.Text = "addinvform";
            this.Load += new System.EventHandler(this.addinvform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox parttxt;
        private System.Windows.Forms.Button incertpartbtn;
        private G13Wst2024DataSetTableAdapters.PartsTableTableAdapter partsTableTableAdapter1;
        private System.Windows.Forms.TextBox quantxt;
        private System.Windows.Forms.TextBox pricetxt;
    }
}