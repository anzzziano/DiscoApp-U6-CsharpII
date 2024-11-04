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
            btnAdd = new System.Windows.Forms.Button();
            buttonModDisc = new System.Windows.Forms.Button();
            btnEliminarFisico = new System.Windows.Forms.Button();
            btnEliminarLogico = new System.Windows.Forms.Button();
            buttonBuscar = new System.Windows.Forms.Button();
            labelFiltro = new System.Windows.Forms.Label();
            textFiltro = new System.Windows.Forms.TextBox();
            labelCampo = new System.Windows.Forms.Label();
            textBoxFiltro = new System.Windows.Forms.TextBox();
            labelCriterio = new System.Windows.Forms.Label();
            labelFiltroAvanzado = new System.Windows.Forms.Label();
            comboBoxCriterio = new System.Windows.Forms.ComboBox();
            comboBoxCampo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dGVWindowIndex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dGVWindowIndex
            // 
            dGVWindowIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVWindowIndex.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dGVWindowIndex.Location = new System.Drawing.Point(40, 98);
            dGVWindowIndex.MultiSelect = false;
            dGVWindowIndex.Name = "dGVWindowIndex";
            dGVWindowIndex.RowHeadersWidth = 51;
            dGVWindowIndex.RowTemplate.Height = 29;
            dGVWindowIndex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dGVWindowIndex.Size = new System.Drawing.Size(807, 414);
            dGVWindowIndex.TabIndex = 0;
            dGVWindowIndex.SelectionChanged += dGVWindowIndex_SelectionChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(904, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(415, 414);
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
            btnRegresarFormDB.Location = new System.Drawing.Point(1191, 561);
            btnRegresarFormDB.Name = "btnRegresarFormDB";
            btnRegresarFormDB.Size = new System.Drawing.Size(128, 68);
            btnRegresarFormDB.TabIndex = 3;
            btnRegresarFormDB.Text = "regresar al indice";
            btnRegresarFormDB.UseVisualStyleBackColor = true;
            btnRegresarFormDB.Click += btnRegresarFormDB_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(40, 538);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(128, 68);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // buttonModDisc
            // 
            buttonModDisc.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonModDisc.Location = new System.Drawing.Point(187, 538);
            buttonModDisc.Name = "buttonModDisc";
            buttonModDisc.Size = new System.Drawing.Size(128, 68);
            buttonModDisc.TabIndex = 5;
            buttonModDisc.Text = "modificar";
            buttonModDisc.UseVisualStyleBackColor = true;
            buttonModDisc.Click += buttonModDisc_Click;
            // 
            // btnEliminarFisico
            // 
            btnEliminarFisico.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEliminarFisico.Location = new System.Drawing.Point(346, 538);
            btnEliminarFisico.Name = "btnEliminarFisico";
            btnEliminarFisico.Size = new System.Drawing.Size(128, 68);
            btnEliminarFisico.TabIndex = 6;
            btnEliminarFisico.Text = "eliminar";
            btnEliminarFisico.UseVisualStyleBackColor = true;
            btnEliminarFisico.Click += btnEliminarFisico_Click;
            // 
            // btnEliminarLogico
            // 
            btnEliminarLogico.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEliminarLogico.Location = new System.Drawing.Point(513, 538);
            btnEliminarLogico.Name = "btnEliminarLogico";
            btnEliminarLogico.Size = new System.Drawing.Size(128, 68);
            btnEliminarLogico.TabIndex = 7;
            btnEliminarLogico.Text = "eliminar logico";
            btnEliminarLogico.UseVisualStyleBackColor = true;
            btnEliminarLogico.Click += btnEliminarLogico_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonBuscar.Location = new System.Drawing.Point(916, 653);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new System.Drawing.Size(128, 40);
            buttonBuscar.TabIndex = 8;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelFiltro
            // 
            labelFiltro.AutoSize = true;
            labelFiltro.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFiltro.Location = new System.Drawing.Point(31, 63);
            labelFiltro.Name = "labelFiltro";
            labelFiltro.Size = new System.Drawing.Size(118, 18);
            labelFiltro.TabIndex = 9;
            labelFiltro.Text = "Filtro rapido";
            // 
            // textFiltro
            // 
            textFiltro.Location = new System.Drawing.Point(155, 59);
            textFiltro.Name = "textFiltro";
            textFiltro.Size = new System.Drawing.Size(232, 27);
            textFiltro.TabIndex = 10;
            textFiltro.TextChanged += textFiltro_TextChanged;
            textFiltro.KeyPress += textFiltro_KeyPress;
            // 
            // labelCampo
            // 
            labelCampo.AutoSize = true;
            labelCampo.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCampo.Location = new System.Drawing.Point(53, 662);
            labelCampo.Name = "labelCampo";
            labelCampo.Size = new System.Drawing.Size(60, 18);
            labelCampo.TabIndex = 11;
            labelCampo.Text = "Campo";
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new System.Drawing.Point(744, 659);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new System.Drawing.Size(136, 27);
            textBoxFiltro.TabIndex = 14;
            textBoxFiltro.TextChanged += textBoxFiltro_TextChanged;
            // 
            // labelCriterio
            // 
            labelCriterio.AutoSize = true;
            labelCriterio.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCriterio.Location = new System.Drawing.Point(339, 664);
            labelCriterio.Name = "labelCriterio";
            labelCriterio.Size = new System.Drawing.Size(76, 18);
            labelCriterio.TabIndex = 15;
            labelCriterio.Text = "Criterio";
            // 
            // labelFiltroAvanzado
            // 
            labelFiltroAvanzado.AutoSize = true;
            labelFiltroAvanzado.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFiltroAvanzado.Location = new System.Drawing.Point(598, 662);
            labelFiltroAvanzado.Name = "labelFiltroAvanzado";
            labelFiltroAvanzado.Size = new System.Drawing.Size(140, 18);
            labelFiltroAvanzado.TabIndex = 16;
            labelFiltroAvanzado.Text = "Filtro Avanzado";
            // 
            // comboBoxCriterio
            // 
            comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCriterio.FormattingEnabled = true;
            comboBoxCriterio.Location = new System.Drawing.Point(421, 658);
            comboBoxCriterio.Name = "comboBoxCriterio";
            comboBoxCriterio.Size = new System.Drawing.Size(151, 28);
            comboBoxCriterio.TabIndex = 17;
            // 
            // comboBoxCampo
            // 
            comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCampo.FormattingEnabled = true;
            comboBoxCampo.Location = new System.Drawing.Point(119, 658);
            comboBoxCampo.Name = "comboBoxCampo";
            comboBoxCampo.Size = new System.Drawing.Size(151, 28);
            comboBoxCampo.TabIndex = 18;
            comboBoxCampo.SelectedIndexChanged += comboBoxCampo_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonShadow;
            ClientSize = new System.Drawing.Size(1346, 726);
            Controls.Add(comboBoxCampo);
            Controls.Add(comboBoxCriterio);
            Controls.Add(labelFiltroAvanzado);
            Controls.Add(labelCriterio);
            Controls.Add(textBoxFiltro);
            Controls.Add(labelCampo);
            Controls.Add(textFiltro);
            Controls.Add(labelFiltro);
            Controls.Add(buttonBuscar);
            Controls.Add(btnEliminarLogico);
            Controls.Add(btnEliminarFisico);
            Controls.Add(buttonModDisc);
            Controls.Add(btnAdd);
            Controls.Add(btnRegresarFormDB);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dGVWindowIndex);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(1364, 699);
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button buttonModDisc;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnEliminarLogico;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textFiltro;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltroAvanzado;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.ComboBox comboBoxCampo;
    }
}