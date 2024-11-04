namespace WinFormsApp1
{
    partial class Form4
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            labelEstilos = new System.Windows.Forms.Label();
            buttonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(128, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(182, 188);
            dataGridView1.TabIndex = 0;
            // 
            // labelEstilos
            // 
            labelEstilos.AutoSize = true;
            labelEstilos.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEstilos.Location = new System.Drawing.Point(137, 22);
            labelEstilos.Name = "labelEstilos";
            labelEstilos.Size = new System.Drawing.Size(183, 18);
            labelEstilos.TabIndex = 1;
            labelEstilos.Text = "Ediciones Disponibles";
            // 
            // buttonCerrar
            // 
            buttonCerrar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCerrar.Location = new System.Drawing.Point(137, 271);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new System.Drawing.Size(148, 57);
            buttonCerrar.TabIndex = 2;
            buttonCerrar.Text = "Cerrar";
            buttonCerrar.UseVisualStyleBackColor = true;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(446, 363);
            Controls.Add(buttonCerrar);
            Controls.Add(labelEstilos);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(464, 410);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(464, 410);
            Name = "Form4";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelEstilos;
        private System.Windows.Forms.Button buttonCerrar;
    }
}