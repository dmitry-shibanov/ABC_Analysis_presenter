using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Analysis_presenter.forms
{
    public partial class ChartWindow : Form
    {
        public delegate void UpdateList(string str);
        public ChartWindow()
        {
            InitializeComponent();
            ListViewItem item = new ListViewItem("dakl");
            //socketManager();

        }

        private void socketManager(string url, string txtMessage, string socketUrl)
        {
           
            var socket = IO.Socket("http://localhost:3000");
            /**
           socket.On("Connected", () =>
           {
               UpdateStatus("Connected");
           });

   */
            WebRequest request = WebRequest.Create("http://localhost:3000");
            request.Method = "POST";

            string postData = txtMessage;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            socket.On(socketUrl, (data) =>
            {
                var message = new { message = "" };
                JObject jObject = (JObject)data;
                string check = jObject.GetValue("message").ToString();
                //var messageValue = JsonConvert.DeserializeAnonymousType((string)check, message);
                UpdateListView(check);
            });
        }

        private void UpdateListView(string str)
        {
            if (listMessages.InvokeRequired)
            {
                UpdateList list = new UpdateList(UpdateListView);
                this.Invoke(list, new object[] { str });
            }
            else
            {
                listMessages.Items.Add(str);
            }
        }

        private void UpdateListThemes(string str)
        {
            if (listSolutions.InvokeRequired)
            {
                UpdateList list = new UpdateList(UpdateListThemes);
                this.Invoke(list, new object[] { str });
            }
            else
            {
                listSolutions.Items.Add(str);
            }
        }

        private void UpdateStatus(string status)
        {

        }

        private void listChats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
