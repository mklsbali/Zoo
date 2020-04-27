using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Model;
using Client.View;
using Server.Persistenta;
using System.ServiceModel;
using System.Windows.Forms;
using System.Data;
namespace Client.Controler
{
    class ControlerAdministator
    {
        private Zoo zoo;
        private ViewAdministrator viewAdministrator;
        private FabricaUtilizator fu;
        private IPersistentaAdministrator pA;
        private NetTcpBinding tcp;
        private DataTable angajati=new DataTable();
        public ControlerAdministator(ViewAdministrator viewAdministrator, Zoo zoo)
        {
            this.viewAdministrator = viewAdministrator;
            this.zoo = zoo;
            fu = new FabricaUtilizator();

            addEventHandlers();
            viewAdministrator.Show();
            creareLegatura();
            actualizareTabelAngajati();
        }
        private void creareLegatura()
        {
            ChannelFactory<IPersistentaAdministrator> canalAdministrator;
            tcp = new NetTcpBinding();
            tcp.OpenTimeout = new TimeSpan(0, 60, 0);
            tcp.SendTimeout = new TimeSpan(0, 60, 0);
            tcp.ReceiveTimeout = new TimeSpan(0, 60, 0);
            tcp.CloseTimeout = new TimeSpan(0, 60, 0);
            tcp.MaxReceivedMessageSize = System.Int32.MaxValue;
            tcp.Security.Mode = SecurityMode.Transport;
            tcp.Security.Transport.ClientCredentialType =
           TcpClientCredentialType.Windows;
            tcp.Security.Transport.ProtectionLevel =
           System.Net.Security.ProtectionLevel.EncryptAndSign;

            canalAdministrator = new ChannelFactory<IPersistentaAdministrator>(tcp, "net.tcp://localhost/8197");
            try
            {
                pA = canalAdministrator.CreateChannel();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void actualizareTabelAngajati()
        {
            try
            {
                angajati.Rows.Clear();
                DataSet ds = pA.actualizareAngajati();
                angajati = ds.Tables["Utilizator"];
                DataGridView table = viewAdministrator.getResultArea();
                table.DataSource = angajati;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void addAngajat(Utilizator utilizator)
        {
            if (utilizator != null)
            {
                try
                {
                    pA.addAngajat(utilizator);
                    actualizareTabelAngajati();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }

        }
        public void deleteAngajat(int id)
        {
            try
            {
                pA.deleteAngajat(id);
                actualizareTabelAngajati();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateAngajat(int id, string newNume, string newPrenume, string newNr, string newEmail, string newUsername, string newPassword)
        {
            Utilizator u = fu.obtineUtilizator("angajat", 5555, newNume, newPrenume, newNr, newEmail, newUsername, newPassword);
            try
            {
                pA.updateAngajat(id, u);
                actualizareTabelAngajati();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void addEventHandlers()
        {
            viewAdministrator.getAddAngajatB().Click += new EventHandler(add_click);
            viewAdministrator.getUpdateAngajatB().Click += new EventHandler(update_click);
            viewAdministrator.getDeleteAngajatB().Click += new EventHandler(delete_click);
            viewAdministrator.getLogoutB().Click += new EventHandler(logout_clcik);
        }
        private void add_click(object sender, EventArgs e)
        {
            Utilizator u = fu.obtineUtilizator("angajat", Int32.Parse(viewAdministrator.getID().Text), viewAdministrator.getNume().Text,
                viewAdministrator.getPrenume().Text, viewAdministrator.getNrTelefon().Text, viewAdministrator.getEmai().Text,
                viewAdministrator.getUsername().Text, viewAdministrator.getPassword().Text);

            addAngajat(u);

        }
        private void update_click(object sender, EventArgs e)
        {

            int id = Int32.Parse(viewAdministrator.getID().Text);
            string newNume = viewAdministrator.getNume().Text;
            string newPrenume = viewAdministrator.getPrenume().Text;
            string newNr = viewAdministrator.getNrTelefon().Text;
            string newEmail = viewAdministrator.getEmai().Text;
            string newUN = viewAdministrator.getUsername().Text;
            string newPassword = viewAdministrator.getPassword().Text;
            updateAngajat(id, newNume, newPrenume, newNr, newEmail, newUN, newPassword);


        }
        private void delete_click(object sender, EventArgs e)
        {
            int id = Int32.Parse(viewAdministrator.getID().Text);

            deleteAngajat(id);



        }
        private void logout_clcik(object sender, EventArgs e)
        {
            viewAdministrator.Hide();
        }
        public Utilizator findAngajatByID(int id)
        {
            foreach (Utilizator a in zoo.getUtilizatori())
            {
                if (a.getID() == id)
                    return a;
            }
            return null;

        }


    }
}
