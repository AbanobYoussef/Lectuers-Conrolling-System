namespace SS.PL
{
    partial class Lecture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecture));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dactivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStudentdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inClassStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Rosewood Std Regular", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.showToolStripMenuItem,
            this.mediaToolStripMenuItem,
            this.toolStripTextBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.endToolStripMenuItem});
            this.controlToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 15F);
            this.controlToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(121, 31);
            this.controlToolStripMenuItem.Text = "control";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateToolStripMenuItem,
            this.dactivateToolStripMenuItem});
            this.systemToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.systemToolStripMenuItem.Text = "system";
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.activateToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.activateToolStripMenuItem.Text = "activate";
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // dactivateToolStripMenuItem
            // 
            this.dactivateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dactivateToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.dactivateToolStripMenuItem.Name = "dactivateToolStripMenuItem";
            this.dactivateToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.dactivateToolStripMenuItem.Text = "dactivate";
            this.dactivateToolStripMenuItem.Click += new System.EventHandler(this.dactivateToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(185, 32);
            this.endToolStripMenuItem.Text = "end";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allStudentdToolStripMenuItem,
            this.inClassStudentsToolStripMenuItem});
            this.showToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 15F);
            this.showToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(92, 31);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // allStudentdToolStripMenuItem
            // 
            this.allStudentdToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.allStudentdToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.allStudentdToolStripMenuItem.Name = "allStudentdToolStripMenuItem";
            this.allStudentdToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.allStudentdToolStripMenuItem.Text = "all studentd";
            this.allStudentdToolStripMenuItem.Click += new System.EventHandler(this.allStudentdToolStripMenuItem_Click);
            // 
            // inClassStudentsToolStripMenuItem
            // 
            this.inClassStudentsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inClassStudentsToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.inClassStudentsToolStripMenuItem.Name = "inClassStudentsToolStripMenuItem";
            this.inClassStudentsToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.inClassStudentsToolStripMenuItem.Text = "in class students";
            this.inClassStudentsToolStripMenuItem.Click += new System.EventHandler(this.inClassStudentsToolStripMenuItem_Click);
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.mediaToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(104, 31);
            this.mediaToolStripMenuItem.Text = "media";
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pdfToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(163, 32);
            this.pdfToolStripMenuItem.Text = "pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.hideToolStripMenuItem});
            this.wordToolStripMenuItem.Font = new System.Drawing.Font("Ravie", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(163, 32);
            this.wordToolStripMenuItem.Text = "State";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.displayToolStripMenuItem.Text = "display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hideToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.hideToolStripMenuItem.Text = "hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Ravie", 10F);
            this.toolStripTextBox1.ForeColor = System.Drawing.Color.Red;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 31);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(656, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 55);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(656, 206);
            this.axAcroPDF1.TabIndex = 3;
            // 
            // Lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(656, 261);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lecture";
            this.Text = "Lecture";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dactivateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStudentdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inClassStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}