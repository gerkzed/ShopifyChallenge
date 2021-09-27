
namespace ShopifyChallenge
{
    partial class mainfrm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPhotoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delphoto = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFullsizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPhotoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 26);
            // 
            // addPhotoToolStripMenuItem
            // 
            this.addPhotoToolStripMenuItem.Name = "addPhotoToolStripMenuItem";
            this.addPhotoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addPhotoToolStripMenuItem.Text = "Add Photo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPhotoToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPhotoToolStripMenuItem1
            // 
            this.addPhotoToolStripMenuItem1.Name = "addPhotoToolStripMenuItem1";
            this.addPhotoToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.addPhotoToolStripMenuItem1.Text = "Add Photo";
            this.addPhotoToolStripMenuItem1.Click += new System.EventHandler(this.addPhotoToolStripMenuItem1_Click);
            // 
            // ListView1
            // 
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(45, 27);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(289, 209);
            this.ListView1.TabIndex = 2;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseClick);
            this.ListView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDown);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(25, 270);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(322, 269);
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delphoto,
            this.viewFullsizeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(143, 48);
            // 
            // delphoto
            // 
            this.delphoto.Name = "delphoto";
            this.delphoto.Size = new System.Drawing.Size(142, 22);
            this.delphoto.Text = "Delete Photo";
            this.delphoto.Click += new System.EventHandler(this.deletePhotoToolStripMenuItem_Click);
            // 
            // viewFullsizeToolStripMenuItem
            // 
            this.viewFullsizeToolStripMenuItem.Name = "viewFullsizeToolStripMenuItem";
            this.viewFullsizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewFullsizeToolStripMenuItem.Text = "View Fullsize";
            this.viewFullsizeToolStripMenuItem.Click += new System.EventHandler(this.viewFullsizeToolStripMenuItem_Click);
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 583);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainfrm";
            this.Text = "Photo Repository";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addPhotoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPhotoToolStripMenuItem1;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem delphoto;
        private System.Windows.Forms.ToolStripMenuItem viewFullsizeToolStripMenuItem;
    }
}

