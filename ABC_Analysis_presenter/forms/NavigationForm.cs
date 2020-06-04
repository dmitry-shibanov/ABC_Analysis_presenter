using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Analysis_presenter.forms
{
    public partial class NavigationForm : Form
    {
        //High level variables
        private Form activeForm = null;
        public delegate void updatePermissions(string str);
        private updatePermissions update;
        public NavigationForm()
        {
            InitializeComponent();
            // initial hide buttons
            signoutButton.Hide();
            iconButtonGraphs.Hide();
            iconButtonAction.Hide();
            iconButtonChooseVector.Hide();
            iconButtonChat.Hide();
            iconButtonServices.Hide();

            //init subcribed delegate
            update = new updatePermissions(UpdatePermissionsFunc);

            // initial form
            Form initForm = new SignForm(update);
            openChildForm(initForm);
        }

        private void UpdatePermissionsFunc(string str)
        {
            if(str == "аналитик")
            {
                iconButtonAction.Show();
                iconButtonChooseVector.Show();
                iconButtonGraphs.Show();
                iconButtonServices.Show();
                iconButtonChat.Show();
                titleChild.Text = "Направления";
                Form eventsForm = new ChooseEvent();
                openChildForm(eventsForm);
            }
            else
            {
                iconButtonChat.Show();
                iconButtonAction.Hide();
                iconButtonChooseVector.Hide();
                iconButtonGraphs.Hide();
            }

            signoutButton.Show();
            iconButtonMain.Hide();
        }

        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonGraphs_Click(object sender, EventArgs e)
        {
            titleChild.Text = "Графики";
            Form graphsForm = new ABCResultForm();
            openChildForm(graphsForm);
        }

        private void iconButtonServices_Click(object sender, EventArgs e)
        {
            titleChild.Text = "Услуги";
            Form mainWindow = new MainWindow();
            openChildForm(mainWindow);
        }

        private void iconButtonChooseVector_Click(object sender, EventArgs e)
        {
            titleChild.Text = "Направления";
            Form eventsForm = new ChooseEvent();
            openChildForm(eventsForm);
        }

        private void signButton_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonMain_Click(object sender, EventArgs e)
        {
            titleChild.Text = "Вход в систему";
            Form initForm = new SignForm(update);
            openChildForm(initForm);
        }

        private void iconButtonChat_Click(object sender, EventArgs e)
        {
            titleChild.Text = "Чат";
            Form chatForm = new ChartWindow();
            openChildForm(chatForm);
        }
    }
}
