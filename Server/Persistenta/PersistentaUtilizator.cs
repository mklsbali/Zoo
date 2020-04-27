using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Server.Persistenta
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
    UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    internal class PersistentaUtilizator : IPersistentaUtilizator
    {
        public PersistentaUtilizator()
        {

        }


        public DataSet actuaizareAngajati()
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
                MySqlCommand vizualizare = new MySqlCommand("Select * from Utilizator", connection);
                MySqlDataAdapter dateCitite = new MySqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "Utilizator");
                connection.Close();
                return ds;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public DataSet vizualizareAnimale()
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
                MySqlCommand vizualizare = new MySqlCommand("Select * from Animal", connection);
                MySqlDataAdapter dateCitite = new MySqlDataAdapter(vizualizare);
                DataSet ds = new DataSet();
                dateCitite.Fill(ds, "Animal");
                connection.Close();
                return ds;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataSet filtrareDupaZonaHabitat(string zona)
        {
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection("datasource=localhost;Database=gradina_zoologica;port=3306;username=root;password=parola");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    //   MessageBox.Show("Connected");
                }
                else
                    MessageBox.Show("Not connected");
                MySqlCommand vizualizare = new MySqlCommand("Select * from Animal where zonaHabitat='" + zona + "'", connection);
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

        public DataSet filtrareDupaTipAlimentatie(string tip)
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
                MySqlCommand vizualizare = new MySqlCommand("Select * from Animal where tipAlimentatie='" + tip + "'", connection);
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

        public DataSet filtrareDupaTipLocomotie(string tip)
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
                MySqlCommand vizualizare = new MySqlCommand("Select * from Animal where tipLocomotie='" + tip + "'", connection);
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
        public DataSet filtrareDupaZonaZoo(string zona)
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
                MySqlCommand vizualizare = new MySqlCommand("Select * from Animal where zonaGradinaZoologica='" + zona + "'", connection);
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

        public DataSet cautareDupaSpecie(string specie)
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
                MySqlCommand vizualizare = new MySqlCommand("Select * from Animal where specie='" + specie + "'", connection);
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
