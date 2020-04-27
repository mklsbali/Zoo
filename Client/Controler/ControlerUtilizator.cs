using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Model;
using Client.View;
using System.Windows.Forms;
using Server.Persistenta;

using System.Data;
using Server;
using System.ServiceModel;




namespace Client.Controler
{
    class ControlerUtilizator
    {
        private Zoo zoo;
        private ViewUtilizator viewUtilizator;
        private IPersistentaUtilizator persistentaUtilizator;
        private NetTcpBinding tcp;
        private DataTable animale;
        private DataTable utilizatori;

        // private Per
        public ControlerUtilizator(ViewUtilizator viewUtilizator, Zoo zoo)
        {
            animale = new DataTable();
            utilizatori = new DataTable();
            this.zoo = zoo;
            this.viewUtilizator = viewUtilizator;
            addEventHandlers();
            creareLegatura();
            actualizareAnimale();
            actualizareUtilizatori();
            Application.EnableVisualStyles();
            Application.Run(viewUtilizator);

        }
        private void creareLegatura()
        {
            ChannelFactory<IPersistentaUtilizator> canalUtilizator;
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

            canalUtilizator = new ChannelFactory<IPersistentaUtilizator>(tcp, "net.tcp://localhost/8199");
            
            try
            {
                persistentaUtilizator = canalUtilizator.CreateChannel();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void actualizareAnimale()
        {
            try
            {
                animale.Rows.Clear();
                DataSet ds = persistentaUtilizator.vizualizareAnimale();
                animale = ds.Tables["Animal"];

                foreach (DataRow dr in this.animale.Rows)
                {
                    Animal a = new Animal((int)dr["Id"], dr["animal"].ToString(), dr["specie"].ToString(), dr["zonaHabitat"].ToString(), dr["tipAlimentatie"].ToString(), dr["tipLocomotie"].ToString(), dr["zonaGradinaZoologica"].ToString());
                    if (!zoo.contineAnimal(a))
                        zoo.adaugareAnimal(a);

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void actualizareUtilizatori()
        {
            FabricaUtilizator fu = new FabricaUtilizator();
            try
            {
                utilizatori.Rows.Clear();
                DataSet ds = persistentaUtilizator.actuaizareAngajati();
                utilizatori = ds.Tables["Utilizator"];

                foreach (DataRow dr in utilizatori.Rows)
                {
                    string tip = dr["tip"].ToString();
                    int id = (int)dr["Id"];
                    string nume = dr["nume"].ToString();
                    string prenume = dr["prenume"].ToString();
                    string nrTelefon = dr["nrTelefon"].ToString();
                    string email = dr["email"].ToString();
                    string username = dr["username"].ToString();
                    string password = dr["password_"].ToString();

                     
                    Utilizator u=null;
                    if (tip.CompareTo("angajat") == 0)
                        u = fu.obtineUtilizator("angajat", id, nume, prenume, nrTelefon, email, username, password);
                    else if (tip.CompareTo("administrator") == 0)
                        u = fu.obtineUtilizator("administrator", id, nume, prenume, nrTelefon, email, username, password);
                    if (u != null)
                        zoo.adaugareUtilizator(u);


                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void vizualizareAnimle()
        {
            try
            {
                actualizareAnimale();
                DataGridView table = viewUtilizator.getResultArea();
                table.DataSource = animale;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }



        }
        public void filtrareDupaZonaHabitat(string zonaHabitat)
        {

            try
            {
                actualizareAnimale();
                animale.Rows.Clear();
                DataSet ds = persistentaUtilizator.filtrareDupaZonaHabitat(zonaHabitat);
                animale = ds.Tables["Animal"];

                DataGridView table = viewUtilizator.getResultArea();
                table.DataSource = animale;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }


        }
        public void filtrareDupaTipAlimentatie(string tipAlimentatie)
        {

            try
            {
                actualizareAnimale();
                animale.Rows.Clear();
                DataSet ds = persistentaUtilizator.filtrareDupaTipAlimentatie(tipAlimentatie);
                animale = ds.Tables["Animal"];

                DataGridView table = viewUtilizator.getResultArea();
                table.DataSource = animale;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        public void filtrareDupaTipLocomotie(string tipLocomotie)
        {

            try
            {
                actualizareAnimale();
                animale.Rows.Clear();
                DataSet ds = persistentaUtilizator.filtrareDupaTipLocomotie(tipLocomotie);
                animale = ds.Tables["Animal"];

                DataGridView table = viewUtilizator.getResultArea();
                table.DataSource = animale;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        public void filtrareDupaZonaGradinaZoologica(string zonaZoo)
        {
            try
            {
                actualizareAnimale();
                animale.Rows.Clear();
                DataSet ds = persistentaUtilizator.filtrareDupaZonaZoo(zonaZoo);
                animale = ds.Tables["Animal"];

                DataGridView table = viewUtilizator.getResultArea();
                table.DataSource = animale;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        public void cautareDupaSpecie(string specie)
        {
            try
            {
                actualizareAnimale();
                animale.Rows.Clear();
                DataSet ds = persistentaUtilizator.cautareDupaSpecie(specie);
                animale = ds.Tables["Animal"];

                DataGridView table = viewUtilizator.getResultArea();
                table.DataSource = animale;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        public void vizualizareDiferiteStatistici()
        {
            vizualizareAnimle();
            List<Animal> animale = zoo.getAnimale();
            List<Frequenty> zonaHabitats = new List<Frequenty>();
            List<Frequenty> tipAlimentatii = new List<Frequenty>();
            List<Frequenty> tipLocomotii = new List<Frequenty>();
            zonaHabitats.Add(new Frequenty(animale[0].getZonaHabitat()));
            tipAlimentatii.Add(new Frequenty(animale[0].getTipAlimentatie()));
            tipLocomotii.Add(new Frequenty(animale[0].getTipLocomotie()));
            zonaHabitats[0].setVal(0);
            tipAlimentatii[0].setVal(0);
            tipLocomotii[0].setVal(0);
            foreach (Animal animal in animale)
            {
                string zonaHabitat = animal.getZonaHabitat();
                string tipAlimentatie = animal.getTipAlimentatie();
                string tipLocomotie = animal.getTipLocomotie();
                if (!contineItem_list(zonaHabitats, zonaHabitat))
                {
                    zonaHabitats.Add(new Frequenty(zonaHabitat));
                }
                else
                {
                    increment_frequenty(zonaHabitats, zonaHabitat);
                }
                if (!contineItem_list(tipAlimentatii, tipAlimentatie))
                {
                    tipAlimentatii.Add(new Frequenty(tipAlimentatie));
                }
                else
                {
                    increment_frequenty(tipAlimentatii, tipAlimentatie);
                }
                if (!contineItem_list(tipLocomotii, tipLocomotie))
                {
                    tipLocomotii.Add(new Frequenty(tipLocomotie));
                }
                else
                {
                    increment_frequenty(tipLocomotii, tipLocomotie);
                }
            }

            if (viewUtilizator.getStatisticiC().SelectedIndex == 0)
            {

                viewUtilizator.getStatisticiChart().Series.Clear();
                viewUtilizator.getStatisticiChart().Series.Add("Zona habitat");
                viewUtilizator.getStatisticiChart().Series["Zona habitat"].Points.Clear();
                foreach (Frequenty zonaH in zonaHabitats)
                {
                    viewUtilizator.getStatisticiChart().Series["Zona habitat"].Points.AddXY(zonaH.getName(), zonaH.getVal());
                }

            }
            else if (viewUtilizator.getStatisticiC().SelectedIndex == 1)
            {
                viewUtilizator.getStatisticiChart().Series.Clear();
                viewUtilizator.getStatisticiChart().Series.Add("Tip alimentatie");
                viewUtilizator.getStatisticiChart().Series["Tip alimentatie"].Points.Clear();
                foreach (Frequenty tipA in tipAlimentatii)
                {
                    viewUtilizator.getStatisticiChart().Series["Tip alimentatie"].Points.AddXY(tipA.getName(), tipA.getVal());
                }
            }
            else if (viewUtilizator.getStatisticiC().SelectedIndex == 2)
            {
                viewUtilizator.getStatisticiChart().Series.Clear();
                viewUtilizator.getStatisticiChart().Series.Add("Tip locomotie");
                viewUtilizator.getStatisticiChart().Series["Tip locomotie"].Points.Clear();
                foreach (Frequenty tipL in tipLocomotii)
                {
                    viewUtilizator.getStatisticiChart().Series["Tip locomotie"].Points.AddXY(tipL.getName(), tipL.getVal());
                }
            }
        }
        private void viewAnimaleClick(object sender, EventArgs e)
        {
            vizualizareAnimle();
        }
        private void filtrareClick(object sender, EventArgs e)
        {
            ComboBox cb = viewUtilizator.getFiltrareC();
            if (cb.SelectedIndex == 0)
                filtrareDupaZonaHabitat(viewUtilizator.getSpecificatieC().SelectedItem.ToString());
            else if (cb.SelectedIndex == 1)
                filtrareDupaTipAlimentatie(viewUtilizator.getSpecificatieC().SelectedItem.ToString());
            else if (cb.SelectedIndex == 2)
                filtrareDupaTipLocomotie(viewUtilizator.getSpecificatieC().SelectedItem.ToString());
            else if (cb.SelectedIndex == 3)
                filtrareDupaZonaGradinaZoologica(viewUtilizator.getSpecificatieC().SelectedItem.ToString());
            else
                viewUtilizator.getResultArea().Text = "Alegeti un tip de filtrare!";
        }

        private void filtrareChanged(object sender, EventArgs e)
        {
            ComboBox filtrare_box = viewUtilizator.getFiltrareC();
            ComboBox specificatie_box = viewUtilizator.getSpecificatieC();
            List<Animal> animale = zoo.getAnimale();


            specificatie_box.Items.Clear();
            foreach (Animal a in animale)
            {
                if (filtrare_box.SelectedIndex == 0)
                {
                    string s = a.getZonaHabitat();
                    if (!contineItem(specificatie_box, s))
                        specificatie_box.Items.Add(s);
                }
                if (filtrare_box.SelectedIndex == 1)
                {
                    string s = a.getTipAlimentatie();
                    if (!contineItem(specificatie_box, s))
                        specificatie_box.Items.Add(s);
                }
                if (filtrare_box.SelectedIndex == 2)
                {
                    string s = a.getTipLocomotie();
                    if (!contineItem(specificatie_box, s))
                        specificatie_box.Items.Add(s);
                }
                if (filtrare_box.SelectedIndex == 3)
                {
                    string s = a.getZonaGradinaZoologica();
                    if (!contineItem(specificatie_box, s))
                        specificatie_box.Items.Add(s);
                }
                else
                    viewUtilizator.getResultArea().Text = "Alegeti o specificatie!";
            }
        }
        private void specieSelected(object sender, EventArgs e)
        {
            ComboBox cb = viewUtilizator.getSpecieC();
            cb.Items.Clear();
            foreach (Animal a in zoo.getAnimale())
            {
                String specie = a.getSpecie();
                if (!contineItem(cb, specie))
                    cb.Items.Add(specie);
            }

        }

        private void specieClick(object sender, EventArgs e)
        {
            cautareDupaSpecie(viewUtilizator.getSpecieC().SelectedItem.ToString());
        }
        private void chartClick(object sender, EventArgs e)
        {
            vizualizareDiferiteStatistici();
        }
        private void administrator_click(object sender, EventArgs e)
        {
            ViewLogin viewLogin = new ViewLogin();
            ControlerLogin cl = new ControlerLogin(viewLogin, zoo, "Administrator");

        }
        private void angajat_click(object sender, EventArgs e)
        {
            ViewLogin viewLogin = new ViewLogin();
            ControlerLogin cl = new ControlerLogin(viewLogin, zoo, "Angajat");
        }



    
        bool contineItem(ComboBox c, string item)
        {
            foreach (string s in c.Items)
            {
                if (item.CompareTo(s) == 0)
                    return true;
            }
            return false;
        }
        bool contineItem_list(List<Frequenty> list, string item)
        {
            foreach (Frequenty s in list)
            {
                if (item.CompareTo(s.getName()) == 0)
                    return true;
            }
            return false;
        }
        public void increment_frequenty(List<Frequenty> frequenties, string item)
        {
            foreach (Frequenty f in frequenties)
            {
                if (f.getName().CompareTo(item) == 0)
                {
                    f.setVal(f.getVal() + 1);
                }
            }
        }
        public void addEventHandlers()
        {
            viewUtilizator.getAnimaleB().Click += new EventHandler(viewAnimaleClick);
            viewUtilizator.getfiltrareB().Click += new EventHandler(filtrareClick);
            viewUtilizator.getFiltrareC().SelectedIndexChanged += new EventHandler(filtrareChanged);
            viewUtilizator.getCautareB().Click += new EventHandler(specieClick);
            viewUtilizator.getSpecieC().Click += new EventHandler(specieSelected);
            viewUtilizator.getAdministratorB().Click += new EventHandler(administrator_click);
            viewUtilizator.getAngajatB().Click += new EventHandler(angajat_click);
            viewUtilizator.getStatisticiB().Click += new EventHandler(chartClick);
        }
    }
}
/*

public void setResult(RichTextBox rt, Animal animal)
{
    rt.Text += "Animal ID:" + animal.getID() + "\nAnimal: " + animal.getAnimal() + "\n" +
      "Specie: " + animal.getSpecie() + "\n" +
      "Zona habitat: " + animal.getZonaHabitat() + "\n" +
      "Tip alimentatie: " + animal.getTipAlimentatie() + "\n" +
      "Tip locomotie: " + animal.getTipLocomotie() + "\n" +
      "Zona gradina zoologica: " + animal.getZonaGradinaZoologica() + "\n\n";
}*/
