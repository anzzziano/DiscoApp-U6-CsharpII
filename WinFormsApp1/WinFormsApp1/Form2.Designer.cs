namespace WinFormsApp1
{
    partial class Form2
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
            dGVWindowIndex = new System.Windows.Forms.DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            btnRegresarFormDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dGVWindowIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dGVWindowIndex
            // 
            dGVWindowIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVWindowIndex.Location = new System.Drawing.Point(40, 43);
            dGVWindowIndex.Name = "dGVWindowIndex";
            dGVWindowIndex.RowHeadersWidth = 51;
            dGVWindowIndex.RowTemplate.Height = 29;
            dGVWindowIndex.Size = new System.Drawing.Size(807, 469);
            dGVWindowIndex.TabIndex = 0;
            dGVWindowIndex.SelectionChanged += dGVWindowIndex_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(904, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(415, 469);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(406, -10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(410, 50);
            label1.TabIndex = 2;
            label1.Text = "discos diponibles";
            // 
            // btnRegresarFormDB
            // 
            btnRegresarFormDB.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegresarFormDB.Location = new System.Drawing.Point(904, 538);
            btnRegresarFormDB.Name = "btnRegresarFormDB";
            btnRegresarFormDB.Size = new System.Drawing.Size(128, 68);
            btnRegresarFormDB.TabIndex = 3;
            btnRegresarFormDB.Text = "regresar al indice";
            btnRegresarFormDB.UseVisualStyleBackColor = true;
            btnRegresarFormDB.Click += btnRegresarFormDB_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ClientSize = new System.Drawing.Size(1346, 652);
            Controls.Add(btnRegresarFormDB);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dGVWindowIndex);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Base De Datos De Discos";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dGVWindowIndex).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dGVWindowIndex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresarFormDB;
    }
}