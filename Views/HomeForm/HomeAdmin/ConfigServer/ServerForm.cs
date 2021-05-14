using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Config.ChatService;

namespace Views.HomeForm.HomeAdmin
{
    public partial class ServerForm : Form
    {
        private delegate void actualiserStatusCallback(string strMessage);

        private bool isConnect = false;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void BtnStartserver_Click(object sender, EventArgs e)
        {
            if (isConnect)
            {
                Application.Exit();
                return;
            }

            if (txtIP.Text == string.Empty)
            {
                MessageBox.Show("  check out the address IP ");
                txtIP.Focus();
                return;
            }

            try
            {
                // analyse de address IP du server mentionne dans la textBox
                IPAddress addressIP = IPAddress.Parse(txtIP.Text);
                int portHost = (int) numericPORT.Value;

                
                //cree une nouvelle instance de  lobjet 
                Server mainServer = new Server(addressIP, portHost);

                // on va lier la gestion des events StatusChanged a mainServer_StatusChanged
                Server.statusChanged += new StatusChangedEventHandler(mainServer_StatusChanged);

                //initie les connexion presentes
                mainServer.initPrensence();

                //montrons que nous avons initier les connexions presntes
                listLog.Items.Add("Serveur actif, en attente de connexion d'un user... ");
                listLog.SetSelected(listLog.Items.Count - 1, true);

            }
            catch (Exception exception)
            {
                listLog.Items.Add("Connection error : " + exception.Message);
                listLog.SetSelected(listLog.Items.Count - 1, true);
            }

            isConnect = true;
            txtIP.Enabled = false;
            numericPORT.Enabled = false;
            btnStartserver.ForeColor = Color.Red;
            btnStartserver.Text = "Quit";
        }

        public void mainServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // call method that actualize the form
            this.Invoke(new actualiserStatusCallback(this.actualizeStatus), new object[] {e.EventMessage});
        }

        private void actualizeStatus(string strmessage)
        {
            // actualize a list with message
            listLog.Items.Add(strmessage);
            listLog.SetSelected(listLog.Items.Count - 1, true);
        }
    }
}
