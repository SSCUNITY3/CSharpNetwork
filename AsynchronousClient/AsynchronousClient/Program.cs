using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Windows.Forms;
using AsynchronousClient;

namespace UdemyAsyncSocketServer
=======
using LahoreSocketAsync;


namespace UdemyAsyncSocketClient
>>>>>>> Haran
{
    class Program

    {
       /* struct dataFormat
        {
            int id;
            string instructorName;
            float floatVal0;
            float floatVal1;
            float floatVal2;
        }*/
        static void Main(string[] args)

        {
            //string data = "1;Instructor1;32.8;102.9;43.9";
            //string[] fetchedData = data.Split(';');
            //for(int i=0; i<fetchedData.Length; i++)
            //{
             //   Console.Write(fetchedData[i]);
            //}

            LahoreSocketClient client = new LahoreSocketClient();

            Console.WriteLine("*** Welcome to Socket Client Starter Example by Naeem Akram Malik ***");
            Console.WriteLine("Please Type a Valid Server IP Address and Press Enter: ");

            string strIPAddress = Console.ReadLine();

            Console.WriteLine("Please Supply a Valid Port Number 0 - 65535 and Press Enter: ");
            string strPortInput = Console.ReadLine();

            if( !client.SetServerIPAddress(strIPAddress) || 
                    !client.SetPortNumber(strPortInput))
            {
                Console.WriteLine(
                    string.Format(
                        "Wrong IP Address or port number supplied - {0} - {1} - Press a key to exit",
                        strIPAddress, 
                    strPortInput));
                Console.ReadKey();
                return;
            }

            client.ConnectToServer();

            string strInputUser = null;

            do
            {
                strInputUser = Console.ReadLine();

                if (strInputUser.Trim() != "<EXIT>")
                {
                    client.SendToServer(strInputUser);
                }
                else if(strInputUser.Equals("<EXIT>"))
                {
                    client.CloseAndDisconnect();
                }
                
            } while (strInputUser != "<EXIT>");



        }
    }
}
