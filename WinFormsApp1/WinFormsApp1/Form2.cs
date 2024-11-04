using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        private List<Disco> listaDeDisco;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            cargar();

            comboBoxCampo.Items.Add("Estilo");


        }

        private void cargar()
        {
            DiscoData dataDisc = new DiscoData();

            try
            {
                listaDeDisco = dataDisc.listar();
                dGVWindowIndex.DataSource = listaDeDisco;
                ocultarColumnas();
                loadImage(listaDeDisco[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dGVWindowIndex.Columns["UrlImagenTapa"].Visible = false;
            dGVWindowIndex.Columns["Id"].Visible = false;
        }


        private void btnRegresarFormDB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVWindowIndex_SelectionChanged(object sender, EventArgs e)
        {


            if (dGVWindowIndex.CurrentRow != null)
            {
                Disco discoSeleccionado = (Disco)dGVWindowIndex.CurrentRow.DataBoundItem;
                loadImage(discoSeleccionado.UrlImagenTapa);
            }
        }

        private void loadImage(string image)
        {
            try
            {
                pictureBox1.Load(image);
            }
            catch (Exception ex)
            {
                pictureBox1.Load("https://t4.ftcdn.net/jpg/06/71/92/37/360_F_671923740_x0zOL3OIuUAnSF6sr7PuznCI5bQFKhI0.jpg");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddDisco addDisco = new FormAddDisco();
            addDisco.ShowDialog();
            cargar();
        }

        private void buttonModDisc_Click(object sender, EventArgs e)
        {
            Disco seleccionado;

            if (dGVWindowIndex.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un disco para modificar");
                return;
            }

           seleccionado = (Disco)dGVWindowIndex.CurrentRow.DataBoundItem;
           

            FormAddDisco modificarDisco = new FormAddDisco(seleccionado);
            modificarDisco.ShowDialog();
            cargar();
        }


        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {

            eliminar();

        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {

            eliminar(true);

        }

        private void eliminar(bool logico = false)
        {
            DiscoData data = new DiscoData();
            Disco discoSeleccionado;

            try
            {

                DialogResult respuesta = MessageBox.Show("seguro que desea eliminar?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                //Verificar la respuesta del usuario:
                if (respuesta == DialogResult.Yes)
                {
                    //Seleccionar el disco a eliminar de la celda de la DGV
                    discoSeleccionado = (Disco)dGVWindowIndex.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        data.eliminarLogico(discoSeleccionado.Id);
                    }
                    else
                    {
                        data.eliminar(discoSeleccionado.Id);
                    }
                    //Dependiendo del valor de la variable logico,
                    //se decide si realizar una eliminación lógica
                    //(que podría marcar el elemento como eliminado
                    //sin borrarlo físicamente) o una eliminación física
                    //(borrarlo
                    //completamente de la base de datos).
                    //En ambos casos, se utiliza el Id del disco seleccionado.

                    cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (comboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecciona un campo ");
                return true;
            }
            if(comboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("por favor, selecciona un criterio");
                    return true;
            } 
            if(comboBoxCampo.SelectedItem.ToString() == "Numero")
            {

                if (string.IsNullOrEmpty(textBoxFiltro.Text))
                {
                    MessageBox.Show("debe cargar el filtro para la busqueda");
                    return true;
                }
                if (!(soloNumeros(textBoxFiltro.Text)))
                {
                    MessageBox.Show("solo puede escribir numeros");
                    return true;
                }
     
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {

                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            DiscoData discoData = new DiscoData();

            try
            {

                if (validarFiltro()) {
                    return;
                }

                string campo = comboBoxCampo.SelectedItem.ToString();
                string criterio = comboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltro.Text;

                // buscar un disco por su estilo filtrando por campo(estilo) ,
                // criterio(empieza ,termina,tiene) , y filtro(seria el estilo
                // que busca el usuario(texto de la textbox))
                try
                {
                    dGVWindowIndex.DataSource = discoData.filtrar(campo, criterio, filtro);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void textFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textFiltro_TextChanged(object sender, EventArgs e)
        {

            List<Disco> listaFiltrada;

            string filtro = textFiltro.Text;


            if (filtro.Length >= 2)
            {

                listaFiltrada = listaDeDisco.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Estilo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {

                listaFiltrada = listaDeDisco;

            }

            dGVWindowIndex.DataSource = null;
            dGVWindowIndex.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void comboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string opcion = comboBoxCampo.SelectedItem.ToString();

                comboBoxCriterio.Items.Clear();
                comboBoxCriterio.Items.Add("Comienza Con");
                comboBoxCriterio.Items.Add("Termina Con");
                comboBoxCriterio.Items.Add("Contiene");
            
        }

        private void textBoxFiltro_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
