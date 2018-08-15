using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LahoreSocketAsync;


namespace UdemyAsyncSocketClient
{
    struct DataFormat
    {
       public int id;
       public string instructorName;
        public float floatVal0;
        public float floatVal1;
        public float floatVal2;
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Program obj = new Program();
            string data = "1;instructor1;32.8;102.9;43.9";
           // string string0, string1, string2, string3;
            string[] fetchedData = data.Split(';');
            DataFormat dataFormat = obj.ConvertStringToStruct(fetchedData);
            obj.PrintStruct(dataFormat);
            string parsedString = obj.ConvertStructToString(dataFormat);
            Console.Write("/n" + parsedString);
            
            //obj.ConvertStringToStruct(fetchedData);
            
            //for (int i = 0; i < fetchedData.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        Int32.TryParse(fetchedData[i], out dataFormat.id);
            //        Console.Write("ID:" + dataFormat.id );
            //    }
            //    if (i == 1)
            //    {
            //        dataFormat.instructorName = fetchedData[i];
            //        Console.Write("\nInstructor Name:" + dataFormat.instructorName);
            //    }
            //    if (i == 2)
            //    {
            //       dataFormat.floatVal0 = float.Parse(fetchedData[i]);
            //        Int32.TryParse(fetchedData[0], out dataFormat.id);
            //        Console.Write("\nFloatValue1:" + dataFormat.floatVal0);
            //    }
            //    if (i == 3)
            //    {
            //        dataFormat.floatVal1 = float.Parse(fetchedData[i]);
            //         Int32.TryParse(fetchedData[0], out dataFormat.id);
            //        Console.Write("\nFloatValue2:" + dataFormat.floatVal1);
            //    }
            //    if (i == 4)
            //    {
            //        dataFormat.floatVal2 = float.Parse(fetchedData[i]);
            //         Int32.TryParse(fetchedData[0], out dataFormat.id);
            //        Console.Write("\nFloatValue3:" + dataFormat.floatVal2);
            //    }
            //    Console.Write(fetcheddata[i] + " ");
            //}

            LahoreSocketClient client = new LahoreSocketClient();

            Console.WriteLine("\n*** Welcome to Socket Client Starter Example by Naeem Akram Malik ***");
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
        void PrintStruct(DataFormat dataFormat)
        {
            Console.Write("ID:" + dataFormat.id);
            Console.Write("\nInstructor Name:" + dataFormat.instructorName);
            Console.Write("\nFloatValue1:" + dataFormat.floatVal0);
            Console.Write("\nFloatValue2:" + dataFormat.floatVal1);
            Console.Write("\nFloatValue3:" + dataFormat.floatVal2);
        }
        String ConvertStructToString(DataFormat dataFormat)
        {
            string dataToBeSent = "";
            dataToBeSent = dataFormat.id + ";" + dataFormat.instructorName + ";" + dataFormat.floatVal0 + ";" + dataFormat.floatVal1 + ";" + dataFormat.floatVal2;
            //dataToBeSent += dataFormat.id;
            //dataToBeSent += dataFormat.instructorName;
            //dataToBeSent += dataFormat.floatVal0;
            //dataToBeSent += dataFormat.floatVal1;
            //dataToBeSent += dataFormat.floatVal2;
            return dataToBeSent;
        }
       DataFormat ConvertStringToStruct(string[] fetchedData)
       {
            //string[] fetchedData = textToParse.Split(';');
            DataFormat dataFormat = new DataFormat();
            for (int i = 0; i < fetchedData.Length; i++)
            {
                if (i == 0)
                {
                    Int32.TryParse(fetchedData[i], out dataFormat.id);
                   
                }
                if (i == 1)
                {
                    dataFormat.instructorName = fetchedData[i];
                    
                }
                if (i == 2)
                {
                    dataFormat.floatVal0 = float.Parse(fetchedData[i]);
                    // Int32.TryParse(fetchedData[0], out dataFormat.id);
                   
                }
                if (i == 3)
                {
                    dataFormat.floatVal1 = float.Parse(fetchedData[i]);
                    // Int32.TryParse(fetchedData[0], out dataFormat.id);
                   
                }
                if (i == 4)
                {
                    dataFormat.floatVal2 = float.Parse(fetchedData[i]);
                    // Int32.TryParse(fetchedData[0], out dataFormat.id);
                   
                }
                //Console.Write(fetcheddata[i] + " ");
            }
            //DataFormat structToReturn;
            return dataFormat;
       }
        

    }

}
