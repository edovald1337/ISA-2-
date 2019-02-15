using System;
using System.IO;
using System.Net;


namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            Console.WriteLine();
            Console.WriteLine();
            File.WriteAllText(@"C:\Users\rawliito\Desktop\WriteText.txt", reply);
            Console.ReadLine();
        }
    }
}
