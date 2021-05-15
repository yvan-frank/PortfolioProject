using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Config.ChatService
{
    // cette classe traite les connexion, seront autant d'instance de user connecté
    class Connexion
    {
        private TcpClient tcpClient;

        //un thread qui va envoyer les informations a un client

        private Thread threadSender;
        private StreamReader streamReaderRecepteur;
        private StreamWriter streamWriterExpediteur;
        private string userActual;
        private string strResponse;

        //constructor qui va prendre la connexio TCP
        public Connexion(TcpClient tcpCon)
        {
            tcpClient = tcpCon;

            //un thread qui accepte la connexion et attend un message
            threadSender = new Thread(acceptClient);
            threadSender.IsBackground = true;
            threadSender.Start();
        }

        private void FermerConnexion()
        {
            //ferme les objets ouverts
            tcpClient.Close();
            streamReaderRecepteur.Close();
            streamWriterExpediteur.Close();
        }

        //se produit lorsqu'un nouveau client est accepté
        private void acceptClient()
        {
            streamReaderRecepteur = new StreamReader(tcpClient.GetStream());
            streamWriterExpediteur = new StreamWriter(tcpClient.GetStream());

            //lire les informations du compte client
            userActual = streamReaderRecepteur.ReadLine();

            //obtenons une response du client 
            if (userActual != "")
            {
                //on stocke le username in hashtable
                if (Server.htUsers.Contains(userActual))
                {
                    // 0 => signifie non connecté
                    streamWriterExpediteur.WriteLine("0| ce nom existe deja.");
                    streamWriterExpediteur.Flush();
                    FermerConnexion();
                    return;
                }else if (userActual == "Administrator")
                {
                    // 0 => non connecté
                    streamWriterExpediteur.WriteLine("0| ce nom est reserve");
                    streamWriterExpediteur.Flush();
                    FermerConnexion();
                    return;
                }
                else {
                    // 1 => connecté avec success
                    streamWriterExpediteur.WriteLine("1");
                    streamWriterExpediteur.Flush();

                    //on inclut le user in the hashtable and execute his message
                    Server.IncluiUser(tcpClient, userActual);
                }
            }
            else
            {
                FermerConnexion();
                return;
            }

            try
            {
                //attend toujours un message de user
                while ((strResponse = streamReaderRecepteur.ReadLine()) != "")
                {
                    //si invalide, supprime
                    if (strResponse == null)
                    {
                        Server.removeUser(tcpClient);
                    }
                    else
                    {
                        //send message for all users
                        Server.EnvoyerMessage(userActual, strResponse);

                    }
                }
            }
            catch
            {
               // si il ya un pb avec cet user, deconnexion
               Server.removeUser(tcpClient);
            }
        }
    }
}
