namespace WinFormsApp1
{
    partial class FormAddDisco
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
            textBoxTitulo = new System.Windows.Forms.TextBox();
            lblTitulo = new System.Windows.Forms.Label();
            lblCantidadCanciones = new System.Windows.Forms.Label();
            buttonAdd = new System.Windows.Forms.Button();
            buttonCancelar = new System.Windows.Forms.Button();
            labelEstilo = new System.Windows.Forms.Label();
            comboBoxEstilo = new System.Windows.Forms.ComboBox();
            labelTipoEdicion = new System.Windows.Forms.Label();
            comboBoxTipoEdicion = new System.Windows.Forms.ComboBox();
            numericUpDownCantCanc = new System.Windows.Forms.NumericUpDown();
            textBoxUrlImagen = new System.Windows.Forms.TextBox();
            labelUrlImagen = new System.Windows.Forms.Label();
            pictureBoxUrlImagenFormAddDisc = new System.Windows.Forms.PictureBox();
            buttonAgregarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantCanc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUrlImagenFormAddDisc).BeginInit();
            SuspendLayout();
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new System.Drawing.Point(157, 76);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new System.Drawing.Size(173, 27);
            textBoxTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitulo.Location = new System.Drawing.Point(76, 80);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(61, 18);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Titulo";
            // 
            // lblCantidadCanciones
            // 
            lblCantidadCanciones.AutoSize = true;
            lblCantidadCanciones.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCantidadCanciones.Location = new System.Drawing.Point(12, 140);
            lblCantidadCanciones.Name = "lblCantidadCanciones";
            lblCantidadCanciones.Size = new System.Drawing.Size(187, 18);
            lblCantidadCanciones.TabIndex = 5;
            lblCantidadCanciones.Text = "Cantidad De Canciones";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAdd.Location = new System.Drawing.Point(58, 346);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(94, 62);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "agregar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCancelar.Location = new System.Drawing.Point(236, 346);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new System.Drawing.Size(94, 62);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelEstilo
            // 
            labelEstilo.AutoSize = true;
            labelEstilo.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEstilo.Location = new System.Drawing.Point(12, 230);
            labelEstilo.Name = "labelEstilo";
            labelEstilo.Size = new System.Drawing.Size(129, 18);
            labelEstilo.TabIndex = 9;
            labelEstilo.Text = "estilo / genero";
            // 
            // comboBoxEstilo
            // 
            comboBoxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxEstilo.FormattingEnabled = true;
            comboBoxEstilo.Location = new System.Drawing.Point(157, 226);
            comboBoxEstilo.Name = "comboBoxEstilo";
            comboBoxEstilo.Size = new System.Drawing.Size(173, 28);
            comboBoxEstilo.TabIndex = 3;
            // 
            // labelTipoEdicion
            // 
            labelTipoEdicion.AutoSize = true;
            labelTipoEdicion.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTipoEdicion.Location = new System.Drawing.Point(12, 280);
            labelTipoEdicion.Name = "labelTipoEdicion";
            labelTipoEdicion.Size = new System.Drawing.Size(129, 18);
            labelTipoEdicion.TabIndex = 11;
            labelTipoEdicion.Text = "tipo / Edicicion";
            // 
            // comboBoxTipoEdicion
            // 
            comboBoxTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxTipoEdicion.FormattingEnabled = true;
            comboBoxTipoEdicion.Location = new System.Drawing.Point(157, 280);
            comboBoxTipoEdicion.Name = "comboBoxTipoEdicion";
            comboBoxTipoEdicion.Size = new System.Drawing.Size(173, 28);
            comboBoxTipoEdicion.TabIndex = 4;
            // 
            // numericUpDownCantCanc
            // 
            numericUpDownCantCanc.Location = new System.Drawing.Point(205, 137);
            numericUpDownCantCanc.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownCantCanc.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCantCanc.Name = "numericUpDownCantCanc";
            numericUpDownCantCanc.Size = new System.Drawing.Size(125, 27);
            numericUpDownCantCanc.TabIndex = 1;
            numericUpDownCantCanc.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCantCanc.KeyPress += numericUpDownCantCanc_KeyPress;
            // 
            // textBoxUrlImagen
            // 
            textBoxUrlImagen.Location = new System.Drawing.Point(157, 182);
            textBoxUrlImagen.Name = "textBoxUrlImagen";
            textBoxUrlImagen.Size = new System.Drawing.Size(173, 27);
            textBoxUrlImagen.TabIndex = 2;
            textBoxUrlImagen.Leave += textBoxUrlImagen_Leave;
            // 
            // labelUrlImagen
            // 
            labelUrlImagen.AutoSize = true;
            labelUrlImagen.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelUrlImagen.Location = new System.Drawing.Point(45, 186);
            labelUrlImagen.Name = "labelUrlImagen";
            labelUrlImagen.Size = new System.Drawing.Size(96, 18);
            labelUrlImagen.TabIndex = 15;
            labelUrlImagen.Text = "Url Imagen";
            // 
            // pictureBoxUrlImagenFormAddDisc
            // 
            pictureBoxUrlImagenFormAddDisc.Location = new System.Drawing.Point(386, 76);
            pictureBoxUrlImagenFormAddDisc.Name = "pictureBoxUrlImagenFormAddDisc";
            pictureBoxUrlImagenFormAddDisc.Size = new System.Drawing.Size(342, 332);
            pictureBoxUrlImagenFormAddDisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxUrlImagenFormAddDisc.TabIndex = 16;
            pictureBoxUrlImagenFormAddDisc.TabStop = false;
            // 
            // buttonAgregarImg
            // 
            buttonAgregarImg.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonAgregarImg.Location = new System.Drawing.Point(336, 182);
            buttonAgregarImg.Name = "buttonAgregarImg";
            buttonAgregarImg.Size = new System.Drawing.Size(46, 29);
            buttonAgregarImg.TabIndex = 17;
            buttonAgregarImg.Text = "+";
            buttonAgregarImg.UseVisualStyleBackColor = true;
            buttonAgregarImg.Click += buttonAgregarImg_Click;
            // 
            // FormAddDisco
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(770, 449);
            Controls.Add(buttonAgregarImg);
            Controls.Add(pictureBoxUrlImagenFormAddDisc);
            Controls.Add(labelUrlImagen);
            Controls.Add(textBoxUrlImagen);
            Controls.Add(numericUpDownCantCanc);
            Controls.Add(comboBoxTipoEdicion);
            Controls.Add(labelTipoEdicion);
            Controls.Add(comboBoxEstilo);
            Controls.Add(labelEstilo);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAdd);
            Controls.Add(lblCantidadCanciones);
            Controls.Add(lblTitulo);
            Controls.Add(textBoxTitulo);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(788, 496);
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(788, 496);
            Name = "FormAddDisco";
            Text = "Agregar Disco";
            Load += FormAddDisco_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantCanc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUrlImagenFormAddDisc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelEstilo;
        private System.Windows.Forms.ComboBox comboBoxEstilo;
        private System.Windows.Forms.Label labelTipoEdicion;
        private System.Windows.Forms.ComboBox comboBoxTipoEdicion;
        private System.Windows.Forms.NumericUpDown numericUpDownCantCanc;
        private System.Windows.Forms.TextBox textBoxUrlImagen;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.PictureBox pictureBoxUrlImagenFormAddDisc;
        private System.Windows.Forms.Button buttonAgregarImg;
    }
}