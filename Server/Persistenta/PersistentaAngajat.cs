using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Server.Model;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Configuration;


namespace Server.Persistenta
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
   UseSynchronizationContext = false, InstanceContextMode = InstanceContextMode.Single)]
    internal class PersistentaAngajat : IPersistentaAngajat
    {
        public PersistentaAngajat()
        {

        }
        public void addAnimal(Animal a)
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
                MySqlCommand add = new MySqlCommand("insert into Animal (animal, specie, zonaHabitat, tipAlimentatie, tipLocomotie, zonaGradinaZoologica) values('"+a.getAnimal()+"','"+a.getSpecie()+"','"+a.getZonaHabitat()+"','"+a.getTipAlimentatie()+"','"+a.getTipLocomotie()+"','"+a.getZonaGradinaZoologica()+"')", connection);
                add.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void deleteAnimal(int id)
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
                MySqlCommand add = new MySqlCommand("delete from Animal where Id=" + id, connection);
                add.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateAnimal(int id, Animal a)
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
                MySqlCommand update = new MySqlCommand("update Animal set animal='"+a.getAnimal()+"',specie='"+a.getSpecie()+"',zonaHabitat='"+a.getZonaHabitat()+"',tipAlimentatie='"+a.getTipAlimentatie()+"',tipLocomotie='"+a.getTipLocomotie()+"',zonaGradinaZoologica='"+a.getZonaGradinaZoologica()+"' where Id="+id, connection);
                update.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
