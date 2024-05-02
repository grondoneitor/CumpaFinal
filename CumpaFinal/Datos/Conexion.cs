using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumpaFinal.Datos
{
    internal class Conexion
    {
        private string conexion = "Data Source=DESKTOP-LVOUQI7;Initial Catalog=CumpaCumpa;Integrated Security=True";

        SqlConnection SQLConection;

        private SqlConnection Conectando()
        {
            this.SQLConection = new SqlConnection(this.conexion);
            return this.SQLConection;

        }


        public bool IniciandoConexion(string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.Conectando();
                this.SQLConection.Open();
                sqlCommand.ExecuteNonQuery();
                this.SQLConection.Close();


                return true;

            }
            catch
            {
                return false;
            }
        }

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando = sqlComando;
                comando.Connection = this.Conectando();
                sqlDataAdapter.SelectCommand = comando;
                SQLConection.Open();
                sqlDataAdapter.Fill(DS);
                SQLConection.Close();
                return DS;

            }
            catch
            {
                return DS;
            }
        }


    }
}
