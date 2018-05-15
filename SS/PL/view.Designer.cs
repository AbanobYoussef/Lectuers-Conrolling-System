namespace SS.PL
{
    partial class view
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrinT = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // PrinT
            // 
            this.PrinT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PrinT.Location = new System.Drawing.Point(0, 241);
            this.PrinT.Name = "PrinT";
            this.PrinT.Size = new System.Drawing.Size(284, 20);
            this.PrinT.TabIndex = 1;
            this.PrinT.Text = "print";
            this.PrinT.UseVisualStyleBackColor = true;
            this.PrinT.Click += new System.EventHandler(this.PrinT_Click);
            // 
            // del
            // 
            this.del.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.del.Location = new System.Drawing.Point(0, 218);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(284, 23);
            this.del.TabIndex = 2;
            this.del.Text = "delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.del);
            this.Controls.Add(this.PrinT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "view";
            this.Text = "view";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrinT;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button del;
    }
}