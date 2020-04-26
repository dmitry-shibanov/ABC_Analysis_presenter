using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABC_Analysis_presenter.forms.NavigationForm;

namespace ABC_Analysis_presenter.forms
{
    public partial class SignForm : Form
    {
        Marketingovoe_agentstvoEntities1 agency = new Marketingovoe_agentstvoEntities1();
        private updatePermissions update;

        public SignForm(updatePermissions update) : base()
        {
            InitializeComponent();
            password_textbox.PasswordChar = '*';
            password_textbox.MaxLength = 14;
            this.update = update;
        }


        private IUser loginSystem(string login, string password)
        {
            IUser user = null;
            Sotrudniki sotrudniki = null;

            foreach (Sotrudniki sotrudnik in agency.Sotrudnikis)
            {
                if (sotrudnik.FIO == login && sotrudnik.Dolzhnost == password)
                {
                    sotrudniki = sotrudnik;
                    break;
                }
            }
            return user;
        }

        private void singIn_button_Click(object sender, EventArgs e)
        {
            string password = password_textbox.Text;
            string login = login_textbox.Text;

            if (password != "аналитик" && password != "дизайнер")
            {
                MessageBox.Show("пользователь не найден");
                return;
            }

            this.Invoke(update, new object[] { password });
        }
    }
}
