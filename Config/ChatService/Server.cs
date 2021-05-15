using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Config.ChatService
{
    // ce delagate est necessaire pour specifier les parametres que nous allons passer avec notre evenement
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

    public class Server
    {
        //cette table de hachage stocke les users et les connexions (access/consultation par les users)
        public static Hashtable htUsers = new Hashtable(30);//limit 30 users
        public static Hashtable htConnexion = new Hashtable(30);//limit 30 connexions
        //stocke les address IP passé
        private IPAddress addressIP;
        private int portHost;
        private TcpClient tcpCliente;

        //l evenement et son argument avertiront le formulaire lorsqu'un user se connecte
        public static event StatusChangedEventHandler statusChanged;
        private static StatusChangedEventArgs e;

        //ici le constructeur definit l'adresse IP de celle renvoyée en instanciant l'objet
        public Server(IPAddress address, int port)
        {
            addressIP = address;
            portHost = port;
        }

        //un thread qui va traiter et executer les connexions
        private Thread threadListener;

        //l'objet TCP qui ecoute les connexions
        private TcpListener tlsClient;

        //dira a la boucle while de continuer a surveiller les connexions
        private bool isServerLaunch = false;

        //inclut un user dans la table de hachage
        public static void IncluiUser(TcpClient tcpUser, string strUsername)
        {
            //inclut d'abord le nom et la connexion dans la table de hachage
            Server.htUsers.Add(strUsername,tcpUser);
            Server.htConnexion.Add(tcpUser, strUsername);

            //informe la nouvelle connexion pour tous les user et pour les formulaire du server
            EnvoyerMessageAdmin(htConnexion[tcpUser] + " is enter...");
        }

        public static void removeUser(TcpClient tcpUser)
        {
            //si un user existe
            if (htConnexion[tcpUser] != null)
            {
                //affiche d'abord les informations et informe les autres users de la connexion
                EnvoyerMessageAdmin(htConnexion[tcpUser] + " out...");

                //remove user from hashtable
                Server.htUsers.Remove(Server.htConnexion[tcpUser]);
                Server.htConnexion.Remove(tcpUser);
            }
        }

        // cet evenement est appelé lorsqu nous voulons declencher l evenement StatusChanged
        public static void onChangedStatus(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = statusChanged;

            if (statusHandler != null)
            {
                //invocation du delagate
                statusHandler(null, e);
            }
        }

        // envoi de message adminstrateur
        public static void EnvoyerMessageAdmin(string message)
        {
            StreamWriter streamWriterSender;
            e = new StatusChangedEventArgs("Administrator: " + message);
            onChangedStatus(e);
             
            //creons un array de client TCps de la taille du nombre de clients existants
            TcpClient[] tcpClients = new TcpClient[Server.htUsers.Count];
            // copie les objets TCP dans le tableau
            Server.htUsers.Values.CopyTo(tcpClients, 0);

            //on parcours la liste de client tcp
            for (int i = 0; i < tcpClients.Length; i++)
            {
                //tente d'envoyer un message pour chaque client
                try
                {
                    // si le message est vide et si la connexion est nulle, on quitte
                    if (message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }

                    //envoi message a user actual dans la boucle
                    streamWriterSender = new StreamWriter(tcpClients[i].GetStream());
                    streamWriterSender.WriteLine("Administrator: " + message);
                    streamWriterSender.Flush();
                    streamWriterSender = null;

                }
                catch 
                {
                   // si on rencontre une erreur et user not exist
                   removeUser(tcpClients[i]);
                }
            }
        }

        //envoie de message dun user pour tous les autres
        public static void EnvoyerMessage(string origine, string message)
        {
            StreamWriter streamWriterSender;

            //affiche d'abord le message dans l'app
            e = new StatusChangedEventArgs(origine + " write :   =>" + message);
            onChangedStatus(e);

            //creons un array de client TCps de la taille du nombre de clients existants
            TcpClient[] tcpClients = new TcpClient[Server.htUsers.Count];
            // copie les objets TCP dans le tableau
            Server.htUsers.Values.CopyTo(tcpClients, 0);

            //on parcours la liste de client tcp
            for (int i = 0; i < tcpClients.Length; i++)
            {
                //tente d'envoyer un message pour chaque client
                try
                {
                    // si le message est vide et si la connexion est nulle, on quitte
                    if (message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }

                    //envoi message a user actual dans la boucle
                    streamWriterSender = new StreamWriter(tcpClients[i].GetStream());
                    streamWriterSender.WriteLine(origine + " write:  " + message);
                    streamWriterSender.Flush();
                    streamWriterSender = null;

                }
                catch
                {
                    // si on rencontre une erreur et user not exist
                    removeUser(tcpClients[i]);
                }
            }
        }

        //initier la presence
        public void initPrensence()
        {
            try
            {
                IPAddress ipLocalAddress = addressIP;
                int portLocal = portHost;

                // cree un objet TCP Listener utilisant l' IP du serveur et du port definis
                tlsClient = new TcpListener(ipLocalAddress, portLocal);

                //initiation de TCp listemner et excecution des connexions
                tlsClient.Start();

                //la boucle while se charge d verifier si le serveur en fonction avant de verifier la connexion
                isServerLaunch = true;
                
                //initier un nouveau thread qui heberge l'auditeur(le port decoute)
                threadListener = new Thread(gardeLaPresence);
                threadListener.IsBackground = true;
                threadListener.Start();

            }
            catch
            {
                //MessageBox.Show("echec to initialize the connection " + exception.Message);
            }
        }

        private void gardeLaPresence()
        {
            //tant que le serveur est en fonctionnement
            while (isServerLaunch)
            {
                //acepte une connexion  en attente
                tcpCliente = tlsClient.AcceptTcpClient();

                //on cree une nouvelle instance de connexion
                Connexion newConnexion = new Connexion(tcpCliente);
            }
        }
    }
}
