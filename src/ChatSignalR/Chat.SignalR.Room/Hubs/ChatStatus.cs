using Chat.SignalR.Room.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.SignalR.Room.Hubs
{
    public class ChatStatus
    {
        public List<string> Connections { get; set; }

        //public Dictionary<string, HashSet<UserDTO>> Users = new Dictionary<string, HashSet<UserDTO>>();

        public ChatStatus()
        {
            Connections = new List<string>();
            //Users = new Dictionary<string, HashSet<UserDTO>>();
        }
    }
}
