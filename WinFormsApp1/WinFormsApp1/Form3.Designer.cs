namespace WinFormsApp1
{
    partial class Form3
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
            dGVFormEstilos = new System.Windows.Forms.DataGridView();
            label1Form3EG = new System.Windows.Forms.Label();
            btnCloseForm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dGVFormEstilos).BeginInit();
            SuspendLayout();
            // 
            // dGVFormEstilos
            // 
            dGVFormEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVFormEstilos.Location = new System.Drawing.Point(89, 89);
            dGVFormEstilos.Name = "dGVFormEstilos";
            dGVFormEstilos.RowHeadersWidth = 51;
            dGVFormEstilos.RowTemplate.Height = 29;
            dGVFormEstilos.Size = new System.Drawing.Size(162, 228);
            dGVFormEstilos.TabIndex = 0;
            // 
            // label1Form3EG
            // 
            label1Form3EG.AutoSize = true;
            label1Form3EG.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1Form3EG.Location = new System.Drawing.Point(75, 38);
            label1Form3EG.Name = "label1Form3EG";
            label1Form3EG.Size = new System.Drawing.Size(194, 26);
            label1Form3EG.TabIndex = 1;
            label1Form3EG.Text = "Estilos / Generos";
            // 
            // btnCloseForm3
            // 
            btnCloseForm3.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCloseForm3.Location = new System.Drawing.Point(109, 338);
            btnCloseForm3.Name = "btnCloseForm3";
            btnCloseForm3.Size = new System.Drawing.Size(126, 79);
            btnCloseForm3.TabIndex = 2;
            btnCloseForm3.Text = "Cerrar";
            btnCloseForm3.UseVisualStyleBackColor = true;
            btnCloseForm3.Click += btnCloseForm3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(334, 450);
            Controls.Add(btnCloseForm3);
            Controls.Add(label1Form3EG);
            Controls.Add(dGVFormEstilos);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(352, 497);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(352, 497);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dGVFormEstilos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dGVFormEstilos;
        private System.Windows.Forms.Label label1Form3EG;
        private System.Windows.Forms.Button btnCloseForm3;
    }
}