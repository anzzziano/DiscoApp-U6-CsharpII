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
            label1 = new System.Windows.Forms.Label();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            agregarDiscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            actualizarDiscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eliminarDiscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dISCOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            verDiscosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buttonCloseWindowIndex = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Location = new System.Drawing.Point(349, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(207, 43);
            label1.TabIndex = 0;
            label1.Text = "Disqueria";
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
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { aDDToolStripMenuItem, dISCOSToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(869, 26);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDDToolStripMenuItem
            // 
            aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { agregarDiscoToolStripMenuItem, actualizarDiscoToolStripMenuItem, eliminarDiscoToolStripMenuItem });
            aDDToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            aDDToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            aDDToolStripMenuItem.Text = "Update Disqueria";
            // 
            // agregarDiscoToolStripMenuItem
            // 
            agregarDiscoToolStripMenuItem.Name = "agregarDiscoToolStripMenuItem";
            agregarDiscoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            agregarDiscoToolStripMenuItem.Text = "Agregar Disco";
            // 
            // actualizarDiscoToolStripMenuItem
            // 
            actualizarDiscoToolStripMenuItem.Name = "actualizarDiscoToolStripMenuItem";
            actualizarDiscoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            actualizarDiscoToolStripMenuItem.Text = "Actualizar Disco";
            // 
            // eliminarDiscoToolStripMenuItem
            // 
            eliminarDiscoToolStripMenuItem.Name = "eliminarDiscoToolStripMenuItem";
            eliminarDiscoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            eliminarDiscoToolStripMenuItem.Text = "Eliminar Disco";
            // 
            // dISCOSToolStripMenuItem
            // 
            dISCOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { verDiscosToolStripMenuItem });
            dISCOSToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dISCOSToolStripMenuItem.Name = "dISCOSToolStripMenuItem";
            dISCOSToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            dISCOSToolStripMenuItem.Text = "DISCOS";
            // 
            // verDiscosToolStripMenuItem
            // 
            verDiscosToolStripMenuItem.Name = "verDiscosToolStripMenuItem";
            verDiscosToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            verDiscosToolStripMenuItem.Text = "Ver Discos";
            verDiscosToolStripMenuItem.Click += verDiscosToolStripMenuItem_Click;
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
            // WindowIndexForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(869, 534);
            Controls.Add(buttonCloseWindowIndex);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "WindowIndexForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Pantalla De Inicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDiscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDiscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDiscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dISCOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDiscosToolStripMenuItem;
        private System.Windows.Forms.Button buttonCloseWindowIndex;
    }
}
