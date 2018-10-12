using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClassLibrary1
{
    class Networking
    {
        public TcpClient TcpClient { get; set; }

        public Networking()
        {
            TcpClient = new TcpClient();
            TcpClient.Connect(new IPEndPoint(new IPAddress(new byte[] { 192, 168, 1, 24 }), 5000));
        }

        public void SendMovement(int dx, int dy)
        {
            var Formatter = new BinaryFormatter();
            MovementChange mv = new MovementChange(dx, dy);
            Formatter.Serialize(TcpClient.GetStream(), mv);
        }
    }
}