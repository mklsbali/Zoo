using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.View;
using Server.Model;
namespace Client.Controler
{
    class ControlerLogin
    {
        private Zoo zoo;
        private ViewLogin viewLogin;
        private ViewAngajat viewAngajat;
        private ViewAdministrator viewAdministrator;
        private string tip_utilizator;

        public ControlerLogin(ViewLogin viewLogin, Zoo zoo, string tip_utilizator)
        {
            this.viewLogin = viewLogin;
            this.zoo = zoo;
            this.tip_utilizator = tip_utilizator;
            viewLogin.getLoginB().Click += new EventHandler(loginClick);
            viewLogin.Show();
        }
        public void logIn()
        {
            string introdus_name = viewLogin.getUserName().Text;
            string introdus_password = viewLogin.getPassword().Text;
            foreach (Utilizator u in zoo.getUtilizatori())
            {
                if (u.getUsername().CompareTo(introdus_name) == 0 && u.getPassword().CompareTo(introdus_password) == 0 && u.GetType().Name.CompareTo(tip_utilizator) == 0)
                {
                    if (tip_utilizator.CompareTo("Angajat") == 0)
                    {
                        viewAngajat = new ViewAngajat();
                        ControlerAngajat ca = new ControlerAngajat(viewAngajat, zoo);
                        viewLogin.Hide();
                    }
                    else if (tip_utilizator.CompareTo("Administrator") == 0)
                    {
                        viewAdministrator = new ViewAdministrator();
                        ControlerAdministator ca = new ControlerAdministator(viewAdministrator, zoo);
                        viewLogin.Hide();
                    }
                    return;

                }

            }
            MessageBox.Show("Fail... incorrect username or password!");
        }
        private void loginClick(object sender, EventArgs e)
        {
            logIn();
        }

    }
}
