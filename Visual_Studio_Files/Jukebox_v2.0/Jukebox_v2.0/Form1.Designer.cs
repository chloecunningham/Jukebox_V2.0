namespace Jukebox_v2._0
{
    partial class Jukebox
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Genre_Textbox = new System.Windows.Forms.TextBox();
            this.Genre_Listbox = new System.Windows.Forms.ListBox();
            this.Playing_Textbox = new System.Windows.Forms.TextBox();
            this.Genre_Scroll = new System.Windows.Forms.HScrollBar();
            this.Playlist_Listbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jukebox_v2._0.Properties.Resources.Jukebox_Image_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 518);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.setToolStripMenuItem.Text = "Set_up";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Copyright © 2018 Chloe Cunningham";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Genre_Textbox
            // 
            this.Genre_Textbox.Location = new System.Drawing.Point(186, 120);
            this.Genre_Textbox.Name = "Genre_Textbox";
            this.Genre_Textbox.ReadOnly = true;
            this.Genre_Textbox.Size = new System.Drawing.Size(183, 20);
            this.Genre_Textbox.TabIndex = 4;
            // 
            // Genre_Listbox
            // 
            this.Genre_Listbox.FormattingEnabled = true;
            this.Genre_Listbox.Location = new System.Drawing.Point(186, 147);
            this.Genre_Listbox.Name = "Genre_Listbox";
            this.Genre_Listbox.Size = new System.Drawing.Size(183, 108);
            this.Genre_Listbox.TabIndex = 5;
            // 
            // Playing_Textbox
            // 
            this.Playing_Textbox.Location = new System.Drawing.Point(186, 286);
            this.Playing_Textbox.Name = "Playing_Textbox";
            this.Playing_Textbox.ReadOnly = true;
            this.Playing_Textbox.Size = new System.Drawing.Size(183, 20);
            this.Playing_Textbox.TabIndex = 6;
            // 
            // Genre_Scroll
            // 
            this.Genre_Scroll.Location = new System.Drawing.Point(186, 258);
            this.Genre_Scroll.Name = "Genre_Scroll";
            this.Genre_Scroll.Size = new System.Drawing.Size(183, 20);
            this.Genre_Scroll.TabIndex = 7;
            // 
            // Playlist_Listbox
            // 
            this.Playlist_Listbox.FormattingEnabled = true;
            this.Playlist_Listbox.Location = new System.Drawing.Point(186, 313);
            this.Playlist_Listbox.Name = "Playlist_Listbox";
            this.Playlist_Listbox.Size = new System.Drawing.Size(183, 108);
            this.Playlist_Listbox.TabIndex = 8;
            // 
            // Jukebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 542);
            this.Controls.Add(this.Playlist_Listbox);
            this.Controls.Add(this.Genre_Scroll);
            this.Controls.Add(this.Playing_Textbox);
            this.Controls.Add(this.Genre_Listbox);
            this.Controls.Add(this.Genre_Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Jukebox";
            this.Text = "My Juke box v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Genre_Textbox;
        private System.Windows.Forms.ListBox Genre_Listbox;
        private System.Windows.Forms.TextBox Playing_Textbox;
        private System.Windows.Forms.HScrollBar Genre_Scroll;
        private System.Windows.Forms.ListBox Playlist_Listbox;
    }
}

