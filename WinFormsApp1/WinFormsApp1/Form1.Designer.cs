namespace WinFormsApp1
{
    partial class WindowIndexForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowIndexForm));
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dISCOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verDiscosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verEstilosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verEdicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buttonCloseWindowIndex = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dISCOSToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(869, 26);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // dISCOSToolStripMenuItem
            // 
            dISCOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { verDiscosToolStripMenuItem, verEstilosToolStripMenuItem, verEdicionesToolStripMenuItem });
            dISCOSToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dISCOSToolStripMenuItem.Name = "dISCOSToolStripMenuItem";
            dISCOSToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            dISCOSToolStripMenuItem.Text = "DISCOS";
            // 
            // verDiscosToolStripMenuItem
            // 
            verDiscosToolStripMenuItem.Name = "verDiscosToolStripMenuItem";
            verDiscosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            verDiscosToolStripMenuItem.Text = "Ver Discos";
            verDiscosToolStripMenuItem.Click += verDiscosToolStripMenuItem_Click;
            // 
            // verEstilosToolStripMenuItem
            // 
            verEstilosToolStripMenuItem.Name = "verEstilosToolStripMenuItem";
            verEstilosToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            verEstilosToolStripMenuItem.Text = "ver estilos";
            verEstilosToolStripMenuItem.Click += verEstilosToolStripMenuItem_Click;
            // 
            // verEdicionesToolStripMenuItem
            // 
            verEdicionesToolStripMenuItem.Name = "verEdicionesToolStripMenuItem";
            verEdicionesToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            verEdicionesToolStripMenuItem.Text = "ver ediciones";
            verEdicionesToolStripMenuItem.Click += verEdicionesToolStripMenuItem_Click;
            // 
            // buttonCloseWindowIndex
            // 
            buttonCloseWindowIndex.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonCloseWindowIndex.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCloseWindowIndex.Location = new System.Drawing.Point(705, 415);
            buttonCloseWindowIndex.Name = "buttonCloseWindowIndex";
            buttonCloseWindowIndex.Size = new System.Drawing.Size(125, 79);
            buttonCloseWindowIndex.TabIndex = 3;
            buttonCloseWindowIndex.Text = "cerrar";
            buttonCloseWindowIndex.UseVisualStyleBackColor = false;
            buttonCloseWindowIndex.Click += buttonCloseWindowIndex_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(371, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(125, 97);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // WindowIndexForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(869, 534);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCloseWindowIndex);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(887, 581);
            Name = "WindowIndexForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Pantalla De Inicio";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dISCOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDiscosToolStripMenuItem;
        private System.Windows.Forms.Button buttonCloseWindowIndex;
        private System.Windows.Forms.ToolStripMenuItem verEstilosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEdicionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
