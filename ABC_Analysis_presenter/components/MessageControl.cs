using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Analysis_presenter.components
{
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }

        public MessageControl(string message, DateTime time) : base()
        {
            this.dateTimeLabel.Text = time.ToShortTimeString();
            this.label2.Text = message;
        }
    }
}
