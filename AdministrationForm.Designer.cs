namespace ADO.Net_Demo
{
    partial class AdministrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageMembersToolStripMenuItem,
            this.manageMoviesToolStripMenuItem,
            this.manageVendorsToolStripMenuItem,
            this.memberReportToolStripMenuItem,
            this.movieReportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageMembersToolStripMenuItem
            // 
            this.manageMembersToolStripMenuItem.Name = "manageMembersToolStripMenuItem";
            this.manageMembersToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.manageMembersToolStripMenuItem.Text = "Manage Members";
            this.manageMembersToolStripMenuItem.Click += new System.EventHandler(this.manageMembersToolStripMenuItem_Click);
            // 
            // manageMoviesToolStripMenuItem
            // 
            this.manageMoviesToolStripMenuItem.Name = "manageMoviesToolStripMenuItem";
            this.manageMoviesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.manageMoviesToolStripMenuItem.Text = "Manage Movies";
            this.manageMoviesToolStripMenuItem.Click += new System.EventHandler(this.manageMoviesToolStripMenuItem_Click);
            // 
            // manageVendorsToolStripMenuItem
            // 
            this.manageVendorsToolStripMenuItem.Name = "manageVendorsToolStripMenuItem";
            this.manageVendorsToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.manageVendorsToolStripMenuItem.Text = "Manage Vendors";
            this.manageVendorsToolStripMenuItem.Click += new System.EventHandler(this.manageVendorsToolStripMenuItem_Click);
            // 
            // memberReportToolStripMenuItem
            // 
            this.memberReportToolStripMenuItem.Name = "memberReportToolStripMenuItem";
            this.memberReportToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.memberReportToolStripMenuItem.Text = "Member Report";
            this.memberReportToolStripMenuItem.Click += new System.EventHandler(this.memberReportToolStripMenuItem_Click);
            // 
            // movieReportToolStripMenuItem
            // 
            this.movieReportToolStripMenuItem.Name = "movieReportToolStripMenuItem";
            this.movieReportToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.movieReportToolStripMenuItem.Text = "Movie Report";
            this.movieReportToolStripMenuItem.Click += new System.EventHandler(this.movieReportToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministrationForm";
            this.Text = "Administration Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}