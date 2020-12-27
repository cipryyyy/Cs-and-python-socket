using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class client {
    public static void Client(Socket socket) {
        bool start=Login(socket);
        if (start) {
            Console.WriteLine("Autenticazione effettuata correttamente");
            byte[] buffer = new byte[256];
            int package;
            string msg;
            byte[] command;
            string rcommand="A";
            
            while (rcommand!="E") {
                Console.Write($"->\t");
                rcommand = Console.ReadLine().ToUpper();
                command = Encoding.ASCII.GetBytes(rcommand);
                socket.Send(command);
                if (rcommand=="E") {
                    continue;
                }

                package = socket.Receive(buffer);
                msg = Encoding.ASCII.GetString(buffer,0,package);
                Console.WriteLine(msg);
            }
        } else {
            Console.WriteLine("Autenticazione fallita");
        }
    }

    public static bool Login(Socket socket) {
        byte[] buffer = new byte[100];
        int package;
        string query;
        byte[] answer;
        string user, password;

        package = socket.Receive(buffer);
        query = Encoding.ASCII.GetString(buffer,0,package);
        Console.Write($"{query}\t");
        user = Console.ReadLine();
        answer = Encoding.ASCII.GetBytes(user);
        socket.Send(answer);

        package = socket.Receive(buffer);
        query = Encoding.ASCII.GetString(buffer,0,package);
        Console.Write($"{query}\t");
        password = Console.ReadLine();
        answer = Encoding.ASCII.GetBytes(password);
        socket.Send(answer);

        package = socket.Receive(buffer);
        string access = Encoding.ASCII.GetString(buffer,0,package);
        if (Convert.ToInt32(access)==1) {
            return true;
        } else {
            return false;
        }
    }

    public static Socket Connector(string ip, int port) {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        Console.WriteLine($"Connecting to {ip}:{port}");
        try {
            s.Connect(ip,port);
            Console.WriteLine($"Connected to {ip}:{port}");
        } catch (Exception e) {
            Console.WriteLine($"Cannot handle this exception:\n{e}");
            Environment.Exit(1);
        }
        return(s);
    }

    public static void Main(String[] args) {
        Socket socket = Connector(IP,PORT);
        Client(socket);
    }
}
