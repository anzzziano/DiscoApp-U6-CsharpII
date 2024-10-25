using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    internal class DiscoData
    {
        public List<Disco> listar()
        {

            List<Disco> listaDiscos = new List<Disco>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT D.Id AS Id, D.Titulo, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion AS Estilo FROM dbo.DISCOS D JOIN dbo.ESTILOS E ON E.Id = D.IdEstilo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)lector["Estilo"];

                    listaDiscos.Add(aux);
                }

                conexion.Close();

                return listaDiscos;
            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

    }
}
