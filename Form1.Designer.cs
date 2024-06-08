
namespace bosssystem1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.invContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.invMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.custmenucontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.custmenubtn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.invoicesbtn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.invDroptimer = new System.Windows.Forms.Timer(this.components);
            this.custDroptimer = new System.Windows.Forms.Timer(this.components);
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sidebar.SuspendLayout();
            this.invContainer.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.custmenucontainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOSS INDUSTRIAL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.invContainer);
            this.sidebar.Controls.Add(this.custmenucontainer);
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel11);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 49);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 545);
            this.sidebar.MinimumSize = new System.Drawing.Size(58, 545);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 545);
            this.sidebar.TabIndex = 1;
            // 
            // invContainer
            // 
            this.invContainer.Controls.Add(this.panel4);
            this.invContainer.Controls.Add(this.panel2);
            this.invContainer.Controls.Add(this.panel5);
            this.invContainer.Location = new System.Drawing.Point(0, 0);
            this.invContainer.Margin = new System.Windows.Forms.Padding(0);
            this.invContainer.MaximumSize = new System.Drawing.Size(207, 150);
            this.invContainer.MinimumSize = new System.Drawing.Size(207, 50);
            this.invContainer.Name = "invContainer";
            this.invContainer.Size = new System.Drawing.Size(207, 50);
            this.invContainer.TabIndex = 4;
            this.invContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.invContainer_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.invMenu);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 50);
            this.panel4.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(206, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1042, 539);
            this.panel10.TabIndex = 3;
            // 
            // invMenu
            // 
            this.invMenu.BackColor = System.Drawing.Color.Black;
            this.invMenu.ForeColor = System.Drawing.Color.White;
            this.invMenu.Image = ((System.Drawing.Image)(resources.GetObject("invMenu.Image")));
            this.invMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invMenu.Location = new System.Drawing.Point(-9, -13);
            this.invMenu.Margin = new System.Windows.Forms.Padding(0);
            this.invMenu.Name = "invMenu";
            this.invMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.invMenu.Size = new System.Drawing.Size(233, 79);
            this.invMenu.TabIndex = 3;
            this.invMenu.Text = "    Inventory";
            this.invMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invMenu.UseVisualStyleBackColor = false;
            this.invMenu.Click += new System.EventHandler(this.invMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 50);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-9, -13);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "View Inventory";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 50);
            this.panel5.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-9, -13);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(233, 79);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Inventory";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // custmenucontainer
            // 
            this.custmenucontainer.Controls.Add(this.panel3);
            this.custmenucontainer.Controls.Add(this.panel6);
            this.custmenucontainer.Controls.Add(this.panel7);
            this.custmenucontainer.Location = new System.Drawing.Point(0, 50);
            this.custmenucontainer.Margin = new System.Windows.Forms.Padding(0);
            this.custmenucontainer.MaximumSize = new System.Drawing.Size(207, 150);
            this.custmenucontainer.MinimumSize = new System.Drawing.Size(207, 50);
            this.custmenucontainer.Name = "custmenucontainer";
            this.custmenucontainer.Size = new System.Drawing.Size(207, 50);
            this.custmenucontainer.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.custmenubtn);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 50);
            this.panel3.TabIndex = 3;
            // 
            // custmenubtn
            // 
            this.custmenubtn.BackColor = System.Drawing.Color.Black;
            this.custmenubtn.ForeColor = System.Drawing.Color.White;
            this.custmenubtn.Image = ((System.Drawing.Image)(resources.GetObject("custmenubtn.Image")));
            this.custmenubtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custmenubtn.Location = new System.Drawing.Point(-9, -13);
            this.custmenubtn.Margin = new System.Windows.Forms.Padding(0);
            this.custmenubtn.Name = "custmenubtn";
            this.custmenubtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.custmenubtn.Size = new System.Drawing.Size(233, 79);
            this.custmenubtn.TabIndex = 3;
            this.custmenubtn.Text = "    Customers";
            this.custmenubtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.custmenubtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.custmenubtn.UseVisualStyleBackColor = false;
            this.custmenubtn.Click += new System.EventHandler(this.custmenubtn_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(0, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(207, 50);
            this.panel6.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-9, -13);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(233, 79);
            this.button4.TabIndex = 3;
            this.button4.Text = "View Customers";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button5);
            this.panel7.Location = new System.Drawing.Point(0, 100);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(207, 50);
            this.panel7.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(-9, -13);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(233, 79);
            this.button5.TabIndex = 3;
            this.button5.Text = "Add Customer";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button2);
            this.panel8.Location = new System.Drawing.Point(0, 100);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(207, 50);
            this.panel8.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-9, -13);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(233, 79);
            this.button2.TabIndex = 3;
            this.button2.Text = "    Orders";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.invoicesbtn);
            this.panel11.Location = new System.Drawing.Point(0, 150);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(207, 50);
            this.panel11.TabIndex = 5;
            // 
            // invoicesbtn
            // 
            this.invoicesbtn.BackColor = System.Drawing.Color.Black;
            this.invoicesbtn.ForeColor = System.Drawing.Color.White;
            this.invoicesbtn.Image = ((System.Drawing.Image)(resources.GetObject("invoicesbtn.Image")));
            this.invoicesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesbtn.Location = new System.Drawing.Point(-9, -13);
            this.invoicesbtn.Margin = new System.Windows.Forms.Padding(0);
            this.invoicesbtn.Name = "invoicesbtn";
            this.invoicesbtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.invoicesbtn.Size = new System.Drawing.Size(233, 79);
            this.invoicesbtn.TabIndex = 3;
            this.invoicesbtn.Text = "    Sales";
            this.invoicesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invoicesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invoicesbtn.UseVisualStyleBackColor = false;
            this.invoicesbtn.Click += new System.EventHandler(this.invoicesbtn_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button6);
            this.panel9.Location = new System.Drawing.Point(0, 200);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(207, 50);
            this.panel9.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-9, -13);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(233, 79);
            this.button6.TabIndex = 3;
            this.button6.Text = "    LogOut";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // invDroptimer
            // 
            this.invDroptimer.Interval = 10;
            this.invDroptimer.Tick += new System.EventHandler(this.invDroptimer_Tick);
            // 
            // custDroptimer
            // 
            this.custDroptimer.Interval = 10;
            this.custDroptimer.Tick += new System.EventHandler(this.custDroptimer_Tick);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 10;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1248, 594);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.invContainer.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.custmenucontainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel invContainer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button invMenu;
        private System.Windows.Forms.Timer invDroptimer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel custmenucontainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button custmenubtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer custDroptimer;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button invoicesbtn;
    }
}

