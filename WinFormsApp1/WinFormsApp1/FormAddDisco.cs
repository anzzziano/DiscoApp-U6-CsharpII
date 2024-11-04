using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.IO;
using System.Configuration;


namespace WinFormsApp1
{
    public partial class FormAddDisco : Form
    {

        private Disco discoN = null;
        private OpenFileDialog archivo = null;

        public FormAddDisco()
        {
            InitializeComponent();
        }

        public FormAddDisco(Disco disco)
        {
            InitializeComponent();
            this.discoN = disco;
            Text = "Modificar disco";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            DiscoData data = new DiscoData();

            try
            {
                if (discoN == null)
                    discoN = new Disco();

                discoN.Titulo = textBoxTitulo.Text;
                discoN.CantidadCanciones = int.Parse(numericUpDownCantCanc.Text);
                discoN.UrlImagenTapa = textBoxUrlImagen.Text;
                discoN.Estilo = (Estilo)comboBoxEstilo.SelectedItem;
                discoN.Edicion = (Edicion)comboBoxTipoEdicion.SelectedItem;

                if (string.IsNullOrWhiteSpace(textBoxTitulo.Text))
                {
                    MessageBox.Show("debe tener titulo");
                    return;
                }

                if (discoN.Id != 0)
                {
                    data.modificar(discoN);
                    MessageBox.Show("modificado exitosamente");
                }
                else if (discoN.Id == 0)
                {
                    data.agregarDisco(discoN);
                    MessageBox.Show("creado exitosamente");
                }

                //guardo imagen si se levanto localmente

                if(archivo != null && !(textBoxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void FormAddDisco_Load(object sender, EventArgs e)
        {
            EstiloData estiloData = new EstiloData();

            EdicionData edicionData = new EdicionData();

            try
            {

                comboBoxEstilo.DataSource = estiloData.listar();
                comboBoxEstilo.ValueMember = "Id";
                comboBoxEstilo.DisplayMember = "Descripcion";

                comboBoxTipoEdicion.DataSource = edicionData.listar();
                comboBoxTipoEdicion.ValueMember = "Id";
                comboBoxTipoEdicion.DisplayMember = "Descripcion";

                if (discoN != null)
                {

                    textBoxTitulo.Text = discoN.Titulo;
                    textBoxUrlImagen.Text = discoN.UrlImagenTapa; // bloque para cuando viene un disco para modificat
                    loadImage(discoN.UrlImagenTapa);//               porque trae algo adentro porque es distinto de nulo

                    comboBoxEstilo.SelectedValue = discoN.Estilo.Id;
                    comboBoxTipoEdicion.SelectedValue = discoN.Edicion.Id;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void numericUpDownCantCanc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                MessageBox.Show("solo puede ingresar numeros enteros");
                e.Handled = true;
            }


        }

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            loadImage(textBoxUrlImagen.Text);
        }

        private void loadImage(string image)
        {
            try
            {
                pictureBoxUrlImagenFormAddDisc.Load(image);
            }
            catch (Exception ex)
            {
                pictureBoxUrlImagenFormAddDisc.Load("https://t4.ftcdn.net/jpg/06/71/92/37/360_F_671923740_x0zOL3OIuUAnSF6sr7PuznCI5bQFKhI0.jpg");
            }
        }

        private void buttonAgregarImg_Click(object sender, EventArgs e)
        {
             archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg";

            if(archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxUrlImagen.Text = archivo.FileName;
                loadImage(archivo.FileName);

               
            }
        }
    }
}
