using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Team_Project_Voting
{
    public class ServerSpeaking
    {
        int discover_port = 4568;
        int port = 4567;
        IPEndPoint serverEndPoint;
        public async Task Login()
        {
            serverEndPoint = await FindServer();
        }
            

        private async Task<IPEndPoint> FindServer()
        {
           using(var client = new UdpClient())
            {
                client.EnableBroadcast = true;
                byte[] requesData = Encoding.UTF8.GetBytes("discover_server");
                await client.SendAsync(requesData, requesData.Length, new IPEndPoint(IPAddress.Broadcast, discover_port));

                await client.SendAsync(requesData, requesData.Length, new IPEndPoint(IPAddress.Parse("26.255.255.255"), discover_port));

                var receive = client.ReceiveAsync();
                var timeout = Task.Delay(200);

                var completed = await Task.WhenAny(receive, timeout);
                if(completed == receive)
                {
                    var result = receive.Result;
                    string response = Encoding.UTF8.GetString(result.Buffer);
                    if (response == "server_here")
                    {
                        IPEndPoint serverEndPoint;
                        serverEndPoint = new IPEndPoint(result.RemoteEndPoint.Address, port);
                        return serverEndPoint;
                    }
                }
            }
           return null;
        }
    }
}