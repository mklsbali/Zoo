using MySql.Data.MySqlClient;
using Server.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
namespace Server.Persistenta
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
  UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    class PersistentaAdministrator : IPersistentaAdministrator
    {
        public PersistentaAdministrator()
        {
           
        }

        public DataSet actualizareAngajati()
        {
            DataSet ds = null;
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("datasource=localhost;Database=gradina_zoologica;port=3306;username=root;password=parola");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //    MessageBox.Show("Connected");
                }
                else
                    MessageBox.Show("Not connected");
                MySqlCommand vizualizare = new MySqlCommand("select * from Utilizator where tip='angajat'", connection);
                MySqlDataAdapter dateCitite = new MySqlDataAdapter(vizualizare);
                ds = new DataSet();
                dateCitite.Fill(ds, "Utilizator");
                connection.Close();
                return ds;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

         }
        public void addAngajat(Utilizator u)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("datasource=localhost;Database=gradina_zoologica;port=3306;username=root;password=parola");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //    MessageBox.Show("Connected");
                }
                else
                    MessageBox.Show("Not connected");
                MySqlCommand add = new MySqlCommand("insert into Utilizator (tip, nume, prenume, nrTelefon, email, username, password_) values('" + u.getTip()+ "','" + u.getNume() + "','" + u.getPrenume() + "','" + u.getNrTelefon() + "','" + u.getEmail() + "','" + u.getUsername() + "','"+u.getPassword()+ "')", connection);
                add.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        public void deleteAngajat(int id)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("datasource=localhost;Database=gradina_zoologica;port=3306;username=root;password=parola");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //    MessageBox.Show("Connected");
                }
                else
                    MessageBox.Show("Not connected");
                MySqlCommand add = new MySqlCommand("delete from Utilizator where Id=" + id, connection);
                add.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void updateAngajat(int id, Utilizator u)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("datasource=localhost;Database=gradina_zoologica;port=3306;username=root;password=parola");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //    MessageBox.Show("Connected");
                }
                else
                    MessageBox.Show("Not connected");
                MySqlCommand update = new MySqlCommand("update Utilizator set tip='angajat', nume='" + u.getNume() + "',prenume='" + u.getPrenume() + "',nrTelefon='" + u.getNrTelefon() + "',email='" + u.getEmail() + "',username='" + u.getUsername()+ "',password_='" + u.getPassword() + "' where Id=" + id, connection);
                update.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public DataSet vizualizareAngajati()
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("datasource=localhost;Database=gradina_zoologica;port=3306;username=root;password=parola");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //    MessageBox.Show("Connected");
                }
                else
                    MessageBox.Show("Not connected");
                MySqlCommand vizualizare = new MySqlCommand("Select * from Utilizator where tip=angajat", connection);
                MySqlDataAdapter dateCitite = new MySqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "Animal");
                connection.Close();
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
