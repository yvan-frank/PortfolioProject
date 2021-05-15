using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.HomeForm.HomeMembreProjet.Form
{
   
    public partial class ClientChat : System.Windows.Forms.Form
    {
        // traiter le nombre de users

        private string username;
        private StreamWriter swExpediteur;
        private StreamReader srRecepteur;

        private TcpClient tcpServer;
        //a necessary method to actualize the form with message
        private delegate void actualizeLogCallback(string strMessage);
        //necessary to define the form for the state "Disconnected" from other Thread
        private delegate void closeConnectionCallBack(string strReason);

        private Thread msgThread;
        private IPAddress addressIp;
        private int portHost;
        private bool isConnected;

        public ClientChat()
        {
            // Exiting the app : disconnected
            Application.ApplicationExit +=  new EventHandler(onApplicationExit);

            InitializeComponent();
        }


        private void BtnCon_Click(object sender, EventArgs e)
        {
            // if your are not connected, waiting the connection
            if (!isConnected)
            {
                // initialize the connection
                InitializeConnection();
            }
            else
            {
                // if isConnected, disconnected
                closeConnection("Disconnected for user asking");
            }
        }
        
        private void BtnSend_Click_1(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void Txtmessage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txtmessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the Enter touch is clicked
            if (e.KeyChar == (char) 13)
            {
                sendMessage();
            }
        }

        private void InitializeConnection()
        {
            try
            {
                // traiter l'ip donné
                addressIp = IPAddress.Parse(txtServerIP.Text);
                portHost = (int) numPortHost.Value;

                //initier une nvelle connxion tcp
                tcpServer = new TcpClient();
                tcpServer.Connect(addressIp, portHost);

                //help to check out if isConnected or no
                isConnected = true;

                //prepare a form
                username = txtUser.Text;

                // desactivate or activate les champs
                txtServerIP.Enabled = false;
                numPortHost.Enabled = false;
                txtUser.Enabled = false;

                txtmessage.Enabled = true;
                btnSend.Enabled = true;

                btnCon.ForeColor = Color.Red;
                btnCon.Text = "Disconnected";

                //envoi du nom au server
                swExpediteur = new StreamWriter(tcpServer.GetStream());
                swExpediteur.WriteLine(txtUser.Text);
                swExpediteur.Flush();

                //init the Thread to receive a message
                msgThread = new Thread(new ThreadStart(ReceivedMessage));
                msgThread.IsBackground = true;
                msgThread.Start();

                lblStatus.Invoke(new Action((() =>
                {
                    lblStatus.ForeColor = Color.ForestGreen;
                    lblStatus.Text = $"Connected to the chat server at {addressIp}  :  {portHost}";
                })));

            }
            catch (Exception ex)
            {
                lblStatus.Invoke(new Action((() =>
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Erreur de connection avec le serveur: \n" + ex.Message;
                })));
            }
        }

        private void ReceivedMessage()
        {
            //receive message from server
            try
            {
                srRecepteur = new StreamReader(tcpServer.GetStream());
                string conResponse = srRecepteur.ReadLine();

                //if the first character of the response is 1, then the connection is established
                if (conResponse[0] == '1')
                {
                    //actualize the form
                    this.Invoke(new actualizeLogCallback(this.actualizeLog), new object[] { $"Successful connected" });
                }
                else
                {
                    string reason = "No connected: ";

                    //extraction the reason of failure
                    reason += conResponse.Substring(2, conResponse.Length - 2);
                    //actualize the form
                    this.Invoke(new closeConnectionCallBack(this.closeConnection), new object[] { reason });
                    return;
                }
            }
            catch
            {
                lblStatus.Invoke(new Action((() =>
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Connexion perdue \n";
                })));
            }

            // tout en etant connecte aux lignes qui arrievent du serveur
            try
            {
                while (isConnected)
                {
                    //show message in textbox
                    this.Invoke(new actualizeLogCallback(this.actualizeLog), new object[] {srRecepteur.ReadLine()});
                }
            }
            catch
            {
               
            }
        }

        private void actualizeLog(string strMessage)
        {
            txtLog.AppendText(strMessage + "\r\n");
        }

        private void sendMessage()
        {
            try
            {
                if (txtmessage.Lines.Length >= 1)
                {
                    swExpediteur.WriteLine(txtmessage.Text);
                    swExpediteur.Flush();
                    txtmessage.Lines = null;

                    this.Invoke(new actualizeLogCallback(actualizeLog), new object[] {txtmessage.Text});
                }

                txtmessage.Text = "";
            }
            catch
            {
                this.Invoke(new actualizeLogCallback(actualizeLog),
                    new object[] {"Le serveur a été désactivé par l'administrateur"});
            }
        }

        private void closeConnection(string mess)
        {
            // close connection with server
            //
            txtLog.AppendText(mess + "\r\n");
            //activate or deactivate controls
            txtServerIP.Enabled = true;
            numPortHost.Enabled = true;
            txtUser.Enabled = true;

            txtmessage.Enabled = false;
            btnSend.Enabled = false;
            btnCon.Text = "Connecter";

            //fermer tout
            isConnected = false;
            swExpediteur.Close();
            srRecepteur.Close();
            tcpServer.Close();

            lblStatus.Invoke(new Action((() =>
            {
                lblStatus.ForeColor = Color.DarkGreen;
                lblStatus.Text = $"Disconnected to Chat Server {addressIp} : {portHost}";
            })));
        }

        // sortir de l'app
        public void onApplicationExit(object sender, EventArgs e)
        {
            if (isConnected)
            {
                isConnected = false;
                swExpediteur.Close();
                srRecepteur.Close();
                tcpServer.Close();
            }
        }

        private void ClientChat_Load(object sender, EventArgs e)
        {

        }
    }
}
