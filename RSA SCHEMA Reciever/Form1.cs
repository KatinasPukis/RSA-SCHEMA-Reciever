using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_SCHEMA_Reciever
{
    public partial class Form1 : Form, Iupdatable
    {


        private Receiver receiver = null;
        public string folderpath = @"TempData\";
        public Form1()
        {
            InitializeComponent();
        }

        private void StartReceiver_Click(object sender, EventArgs e)
        {
            if (receiver == null)
            {
                MessageBox.Show("Recieving!");
                Thread receiverThread = new Thread(() =>
                {
                    receiver = new Receiver(Environment.ExpandEnvironmentVariables(folderpath), this);
                    receiver.Start();
                });
                receiverThread.Start();


            }
        }
        public void displayText(string text)
        {
            Invoke((Action)delegate
            {
                //ReceivedTextBox.Text = this.MyProperty;
                ReceivedTextBox.Text = text;
                //PathTextBox.Text = path;
            });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckSignuture_Click(object sender, EventArgs e)
        {
            
            ASCIIEncoding ByteConverter = new ASCIIEncoding(); // bitu converteris
            string message = ReceivedTextBox.Text; // zinute kuri yra gauta
            string[] text = message.Split(',');
            string originalData = " ";
            string Signuture = " ";
            int counter = 0;
            foreach (var sub in text)
            {
                counter++;
                if(counter==1)
                {
                    originalData = sub;
                }
                if(counter==2)
                {
                    Signuture = sub;
                }
                
            }
            byte[] receivedData = ByteConverter.GetBytes(originalData);
            byte[] signedData = Convert.FromBase64String(Signuture);

            RSADigitalKey rSADigital = new RSADigitalKey();
            rSADigital.VerifyData(receivedData, signedData);



        }
    }
}
