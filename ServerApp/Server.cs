using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerApp
{
    internal class Server
    {
        private TcpListener listener;

        public Server ()
        {
            listener = new TcpListener(IPAddress.Any, 8976);
        }

        public async Task StartAsync()
        {
            listener.Start();

            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync();

                _ = HandleClientAsync(client);
            }
        }

        private async Task HandleClientAsync(TcpClient client)
        {
          
        }
    }
}
