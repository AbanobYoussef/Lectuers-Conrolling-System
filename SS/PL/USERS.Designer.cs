namespace SS.PL
{
    partial class USERS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profeseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profeseursToolStripMenuItem,
            this.lecteursToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.endToolStripMenuItem,
            this.endToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profeseursToolStripMenuItem
            // 
            this.profeseursToolStripMenuItem.Name = "profeseursToolStripMenuItem";
            this.profeseursToolStripMenuItem.Size = new System.Drawing.Size(115, 32);
            this.profeseursToolStripMenuItem.Text = "professeur";
            this.profeseursToolStripMenuItem.Click += new System.EventHandler(this.profeseursToolStripMenuItem_Click);
            // 
            // lecteursToolStripMenuItem
            // 
            this.lecteursToolStripMenuItem.Name = "lecteursToolStripMenuItem";
            this.lecteursToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.lecteursToolStripMenuItem.Text = "lecteurs";
            this.lecteursToolStripMenuItem.Click += new System.EventHandler(this.lecteursToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(98, 32);
            this.studentsToolStripMenuItem.Text = "students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.usersToolStripMenuItem.Text = "users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.endToolStripMenuItem.Text = "stage";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem2
            // 
            this.endToolStripMenuItem2.Name = "endToolStripMenuItem2";
            this.endToolStripMenuItem2.Size = new System.Drawing.Size(57, 32);
            this.endToolStripMenuItem2.Text = "end";
            this.endToolStripMenuItem2.Click += new System.EventHandler(this.endToolStripMenuItem2_Click);
            // 
            // USERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "USERS";
            this.Text = "USERS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profeseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}