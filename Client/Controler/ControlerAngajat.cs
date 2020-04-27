using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Server.Model;
using Client.View;
using System.IO;
using System.Windows.Forms;
using System.ServiceModel;
using Server.Persistenta;
namespace Client.Controler
{
    class ControlerAngajat
    {
        private Zoo zoo;
        private ViewAngajat viewAngajat;
        private IPersistentaAngajat persistentaAngajat;
        private NetTcpBinding tcp;
        public ControlerAngajat(ViewAngajat viewAngajat, Zoo zoo)
        {
            this.viewAngajat = viewAngajat;
            this.zoo = zoo;
            addEventHandlers();
            viewAngajat.Show();
            creare_legatura();
        }
        private void creare_legatura()
        {
            ChannelFactory<IPersistentaAngajat> canalAngajat;
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

            canalAngajat = new ChannelFactory<IPersistentaAngajat>(tcp, "net.tcp://localhost/8198");
            try
            {
                persistentaAngajat = canalAngajat.CreateChannel();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void addAnimal(Animal animal)
        {
            if (animal != null)
            {
                try
                {
                    persistentaAngajat.addAnimal(animal);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
  
            }

        }
        public void deleteAnimal(int id)
        {

            try
            {
                persistentaAngajat.deleteAnimal(id);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void updateAnimal(int id, string newAnimal, string newSpecie, string newZonaH, string newTipA, string newTipL, string newZonaZoo)
        {
            Animal animal= new Animal(newAnimal, newSpecie, newZonaH, newTipA, newTipL, newZonaZoo);
            try
            {
                persistentaAngajat.updateAnimal(id, animal);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void add_click(object sender, EventArgs e)
        {
            int id = Int32.Parse(viewAngajat.getId().Text);
            Animal a = new Animal(viewAngajat.getAnimal().Text, viewAngajat.getSpecie().Text,
                viewAngajat.getZonaHabitat().Text, viewAngajat.getTipAlimentatie().Text,
                viewAngajat.getTipLocomotie().Text, viewAngajat.getZonaZoo().Text);

            addAnimal(a);

        }
        private void update_click(object sender, EventArgs e)
        {
            int id = Int32.Parse(viewAngajat.getId().Text);
            string animal = viewAngajat.getAnimal().Text;
            string specie = viewAngajat.getSpecie().Text;
            string hab = viewAngajat.getZonaHabitat().Text;
            string alim = viewAngajat.getTipAlimentatie().Text;
            string loc = viewAngajat.getTipLocomotie().Text;
            string zzoo = viewAngajat.getZonaZoo().Text;
            updateAnimal(id, animal, specie, hab, alim, loc, zzoo);
        }
        private void delete_click(object sender, EventArgs e)
        {
            int id = Int32.Parse(viewAngajat.getId().Text);
            deleteAnimal(id);


        }
        private void logout_click(object sender, EventArgs e)
        {
            viewAngajat.Hide();
        }
        public void addEventHandlers()
        {
            viewAngajat.getAddB().Click += new EventHandler(add_click);
            viewAngajat.getUpdateB().Click += new EventHandler(update_click);
            viewAngajat.getDeleteB().Click += new EventHandler(delete_click);
            viewAngajat.getLogoutB().Click += new EventHandler(logout_click);
            viewAngajat.getRaportB().Click += new EventHandler(raport_click);
        }
        private void raport_click(object sender, EventArgs e)
        {
            salvareRapoarte();
        }
       
        public void salvareRapoarte()
        {
            if (viewAngajat.getRaportC().SelectedIndex == 0)
            {
                StreamWriter sw;
                try
                {

                    System.IO.File.WriteAllText("raport.csv", string.Empty);
                    sw = new StreamWriter("raport.csv", true);

                    sw.WriteLine("ID,Animal,Specie,Habitat,Alimentatie,Locomotie,ZonaZoo");
                    foreach (Animal a in zoo.getAnimale())
                    {
                        sw.WriteLine(a.getID() + "," + a.getAnimal() + "," + a.getSpecie() + "," + a.getZonaHabitat() + "," +
                            a.getTipAlimentatie() + "," + a.getTipLocomotie() + "," + a.getZonaGradinaZoologica());

                    }
                }
                catch (IOException e)
                {
                    return;
                }
                sw.Close();
            }
            else if (viewAngajat.getRaportC().SelectedIndex == 1)
            {
                try
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.NewLineOnAttributes = true;


                    settings.Indent = true;
                    XmlWriter xmlWriter = XmlWriter.Create("raport.xml", settings);
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Animale");
                    foreach (Animal a in zoo.getAnimale())
                    {
                        xmlWriter.WriteStartElement("Animal");
                        xmlWriter.WriteString("ID: " + a.getID());
                        xmlWriter.WriteString("Animal: " + a.getAnimal());
                        xmlWriter.WriteString("Specie: " + a.getSpecie());
                        xmlWriter.WriteString("ZonaHabitat: " + a.getZonaHabitat());
                        xmlWriter.WriteString("Alimentatie: " + a.getTipAlimentatie());
                        xmlWriter.WriteString("Locomotie: " + a.getTipLocomotie());
                        xmlWriter.WriteString("ZonaZoo: " + a.getZonaGradinaZoologica());

                    }
                    xmlWriter.WriteEndElement();
                    xmlWriter.Close();
                }
                catch (Exception e)
                {
                    return;
                }
            }
            else if (viewAngajat.getRaportC().SelectedIndex == 2)
            {
                StreamWriter sw;
                try
                {

                    System.IO.File.WriteAllText("raport.csv", string.Empty);
                    sw = new StreamWriter("raport.json", true);

                    sw.WriteLine("ID,Animal,Specie,Habitat,Alimentatie,Locomotie,ZonaZoo");
                    foreach (Animal a in zoo.getAnimale())
                    {
                        sw.WriteLine(a.getID() + "," + a.getAnimal() + "," + a.getSpecie() + "," + a.getZonaHabitat() + "," +
                            a.getTipAlimentatie() + "," + a.getTipLocomotie() + "," + a.getZonaGradinaZoologica());

                    }
                }
                catch (IOException e)
                {
                    return;
                }
                sw.Close();
            }
        }
        private  Animal findAnimalByID(int id)
        {
            foreach (Animal a in zoo.getAnimale())
            {
                if (a.getID() == id)
                    return a;
            }
            return null;

        }

    }
}
