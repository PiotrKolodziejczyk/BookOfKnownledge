using System;
using System.IO;
using System.Net;

namespace DownloadPage
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("http://kck.wikidot.com/windows:utf8");
            //request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            
            Stream stream = response.GetResponseStream();
            
            StreamReader reader = new StreamReader(stream);
            string html = reader.ReadToEnd();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
