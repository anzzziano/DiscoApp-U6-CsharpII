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
    public partial class Form3 : Form
    {

        private List<Estilo> listaDeEstilos;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            EstiloData estiloData = new EstiloData();
            listaDeEstilos = estiloData.listar();
            dGVFormEstilos.DataSource = listaDeEstilos;
            dGVFormEstilos.Columns["Id"].Visible = false;

        }

        private void btnCloseForm3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
