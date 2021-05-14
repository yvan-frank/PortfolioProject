using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config.ChatService
{
    //gerons les arguments d un evenement 
    public class StatusChangedEventArgs : EventArgs
    {
        //interessons nous aux messages qui decrivent l evenement
        private string eventMsg;

        //proprité a renvoyer et definr un message d evenement
        public string EventMessage
        {
            get { return eventMsg; }
            set { eventMsg = value; }
        }

        //constructor de la class
        public StatusChangedEventArgs(string strEventMsg)
        {
            eventMsg = strEventMsg;
        }
    }
}
