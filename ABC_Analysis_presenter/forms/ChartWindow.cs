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
            listChats.View = View.Tile;
            listChats.FullRowSelect = true;
            ListViewItem item = new ListViewItem("dakl");

            listChats.Items.Add(new ListViewItem("sdjklsajldjsalal1"));
            listChats.Items.Add(new ListViewItem("sdjklsajldjsalal2"));
            listChats.Items.Add(new ListViewItem("sdjklsajldjsalal3"));
            listChats.Items.Add(new ListViewItem("sdjklsajldjsalal4"));
           // socketManager();

        }

        private void socketManager()
        {
           
            var socket = IO.Socket("http://localhost:3000");
            /**
           socket.On("Connected", () =>
           {
               UpdateStatus("Connected");
           });

   */
            WebRequest request = WebRequest.Create("http://localhost:3000");
            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            string postData = "This is a test that posts this string to a Web server.";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            socket.On("messages", (data) =>
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
            if (listChats.InvokeRequired)
            {
                UpdateList list = new UpdateList(UpdateListView);
                this.Invoke(list, new object[] { str });
            }
            else
            {
                listChats.Items.Add(str);
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
