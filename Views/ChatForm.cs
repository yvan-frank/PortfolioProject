using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Views.HomeForm.HomeMembreProjet.Form;

namespace Views
{
    public partial class ChatForm : Form
    {

        #region Variables 

        private string username;
        private StreamWriter swExpediteur;
        private StreamReader srRecepteur;

        private TcpClient tcpServer;
        //a necessary method to actualize the form with message
        private delegate void ActualizeLogCallback(string strMessage);
        //necessary to define the form for the state "Disconnected" from other Thread
        private delegate void CloseConnectionCallBack(string strReason);

        private Thread msgThread;
        private IPAddress addressIp;
        private int portHost;
        private bool isConnected;

        #endregion




        public ChatForm()
        {
            // Exiting the app : disconnected
            Application.ApplicationExit += new EventHandler(onApplicationExit);
            InitializeComponent();
        }


        #region initilise la connexion
        private void InitializeConnection()
        {
            try
            {
                // traiter l'ip donné
                addressIp = IPAddress.Parse(txtServerIP.Text);
                portHost = (int)numPortHost.Value;

                //initier une nvelle connxion tcp
                tcpServer = new TcpClient();
                tcpServer.Connect(addressIp, portHost);

                //help to check out if isConnected or no
                isConnected = true;

                //prepare a form
                username = txtUsername.Text;

                // desactivate or activate les champs
                txtServerIP.Enabled = false;
                numPortHost.Enabled = false;
                txtUsername.Enabled = false;

                txtmessage.Enabled = true;
                btnSend.Enabled = true;

                btnCon.ForeColor = Color.Red;
                btnCon.Text = "Disconnected";

                //envoi du nom au server
                swExpediteur = new StreamWriter(tcpServer.GetStream());
                swExpediteur.WriteLine(txtUsername.Text);
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


        #endregion




        private void BtnSend_Click(object sender, EventArgs e)
        {
            sendMessage();
        }
     

        #region Message entrant


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
                    MessageBox.Show("Connection successful");
                }
                else
                {
                    string reason = "No connected: ";

                    //extraction the reason of failure
                    reason += conResponse.Substring(2, conResponse.Length - 2);
                    //actualize the form
                    MessageBox.Show(reason);
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
                    this.Invoke(new ActualizeLogCallback(this.ActualizeLogReceiveMessage), new object[] { srRecepteur.ReadLine() });

                }
            }
            catch
            {

            }
        }

        private void ActualizeLogReceiveMessage(string strmessage)
        {
            var bubble = new Controls.MessageEntrant();
            panContainer.Controls.Add(bubble);
            //bubble.Top = cvrTop;//
            bubble.BringToFront();
            //bubble.Width = panContainer.Width - 10;//
            bubble.Dock = DockStyle.Top;
            bubble.Message = strmessage;
            // cvrTop += bubble.Height;//
        }

        #endregion


        #region Message sortant

        private void sendMessage()
        {
            try
            {
                if (txtmessage.Lines.Length >= 1)
                {
                    swExpediteur.WriteLine(txtmessage.Text);
                    swExpediteur.Flush();
                    //txtmessage.Lines = null;

                    this.Invoke(new ActualizeLogCallback(ActualizeLogSendMessage), new object[] { txtmessage.Text });
                }

                txtmessage.Text = "";
            }
            catch
            {
                this.Invoke(new ActualizeLogCallback(ActualizeLogSendMessage),
                    new object[] { "Le serveur a été désactivé par l'administrateur" });
            }
        }


        //log message sortant
        private void ActualizeLogSendMessage(string mess)
        {
            var bubble = new Controls.MessageSortant();
            panContainer.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Message = mess;
        }

        #endregion


        private void closeConnection(string mess)
        {
            // close connection with server
            //
            //txtLog.AppendText(mess + "\r\n");
            //activate or deactivate controls
            txtServerIP.Enabled = true;
            numPortHost.Enabled = true;
            txtUsername.Enabled = true;

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
                lblStatus.Text = $"Disconnected to Chat Server {addressIp} : {portHost}" + mess;
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


        private void TxtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                sendMessage();
            }
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnCon_Click(object sender, EventArgs e)
        {
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
    }
}
