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
    public partial class ChooseEvent : Form
    {
        Marketingovoe_agentstvoEntities1 marketingovoe_ = null;

        public ChooseEvent()
        {
            InitializeComponent();
            marketingovoe_ = new Marketingovoe_agentstvoEntities1();
            listEvenParticipants.View = View.Details;
            listEvents.View = View.Details;
            listofEmployees.View = View.Details;
            listEvenParticipants.OwnerDraw = true;
            listEvents.OwnerDraw = true;
            listofEmployees.OwnerDraw = true;
        }

        private void fillListView(ListView list)
        {
            list.Items.Clear();
                foreach (var item in marketingovoe_.Sotrudnikis)
                {
                    ListViewItem listViewItem = new ListViewItem(new[] { item.FIO, item.Dolzhnost });
                list.Items.Add(listViewItem);
                }
        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillListView(listofEmployees);
        }

        private void listEvenParticipants_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
            e.DrawText();
        }

        private void listEvenParticipants_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void iconButtonAdd_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listofEmployees.SelectedItems)
            {
                if (!listEvenParticipants.Items.Contains(item))
                {
                    listEvenParticipants.Items.Add(item);
                }
            }
        }

        private void listofEmployees_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listofEmployees_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
            e.DrawText();
        }

        private void listEvents_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

        }

        private void listEvents_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
            e.DrawText();
        }
    }
}
