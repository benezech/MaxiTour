using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaxiTour;

using System.Data;
using MySql.Data.MySqlClient;

namespace GestionMaxiTour
{
    class GestionBDD
    {
        private MySqlConnection Connection;
        private MySqlCommand Cmd = new MySqlCommand();
        private MySqlDataAdapter DataAdapt = new MySqlDataAdapter();
        private DataSet ds = new DataSet();
        private string server;
        private string database;
        private string uid;
        private string password;
      
        public void Connexion()
        {
            server = "mysql.montpellier.epsi.fr";
            database = "maxitourbdd";
            uid = "ProfesseursAdmin";
            password = "ProfesseursAdmin";
            string connectionString;
            /*connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";*/

            connectionString = "SERVER=" + server + "; PORT = 5206 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            Connection = new MySqlConnection(connectionString);

            OpenConnection();

            ds = new DataSet("GestionTournee");
            ds.Clear();
            Cmd.CommandType = CommandType.Text;
            Cmd.Connection = Connection;
        }

        private bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Vous ne pouvez pas vous connecter");
                        break;

                    case 1045:
                        MessageBox.Show("Mauvais identifiant");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public DataTable request_select(string requete)
        {
            DataTable result = new DataTable();
            DataSet datas = new DataSet();

            Cmd.CommandText = requete;
            DataAdapt.SelectCommand = Cmd;
            DataAdapt.Fill(datas);

            result = datas.Tables[0];

            return result;

        }


        public string getField_Datable(DataTable datas, int lign, int colonne)
        {
            return Convert.ToString(datas.Rows[lign][colonne]);
        }


        public void request_action(string myrequest)
        {
            try
            {
                Cmd.CommandText = myrequest;
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur dans la tentative d'action", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
