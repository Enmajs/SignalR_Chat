using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.SignalR.Connection.Interface
{
    public interface IConnectionManager
    {
        void ConnectToHub();
    }
}
