﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Client_Server
{

    class Client
    {
        //IPAddress ip;
        //IPEndPoint end = new IPEndPoint(ip, port);
        static IPEndPoint end;
        static Socket sock;
        //int port;
        //Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        ////

        public static string MessageCurrent = "Idle";
        public static byte[] EncapFile(string fName,string convertType)
        {
            try
            {
                string path = "";
                fName = fName.Replace("\\", "/");
                while (fName.IndexOf("/") > -1)
                {
                    path += fName.Substring(0, fName.IndexOf("/") + 1);
                    fName = fName.Substring(fName.IndexOf("/") + 1);
                }
                string fName_temp = fName;
                fName += "/"+ convertType;
                byte[] fNameByte = Encoding.ASCII.GetBytes(fName);
                //MessageCurrent = "Buffering...";
                //MessageCurrent = fName + " convert into " + convertType;
                
                //System.Threading.Thread.Sleep(2000);
                //
                byte[] fileData = File.ReadAllBytes(path + fName_temp);
                byte[] clientData = new byte[4 + fNameByte.Length + fileData.Length];
                byte[] fNameLen = BitConverter.GetBytes(fNameByte.Length);
                fNameLen.CopyTo(clientData, 0);
                fNameByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + fNameByte.Length);
                //
                //MessageCurrent = "Connect to Server....";
                //System.Threading.Thread.Sleep(2000);
                //sock.Connect(end);
                //
                System.Threading.Thread.Sleep(2000);
                MessageCurrent = "The File is sent, Waiting..";
                
                return clientData;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public static bool DecapFile(int receiveByteLen,byte[] serverData)
        {
            try
            {

                //Nhan file
                string path = "D:/Nam3_HK1/PHL4/ReceiveFilefromServer";
                MessageCurrent = "Receiving File...";
                System.Threading.Thread.Sleep(2000);
                int fNameLen = BitConverter.ToInt32(serverData, 0);
                string fName = Encoding.ASCII.GetString(serverData, 4, fNameLen);

                string txbFileName = path + "/" + fName;

                BinaryWriter writer = new BinaryWriter(File.Open(path + "/" + fName, FileMode.Create));
                writer.Write(serverData, 4 + fNameLen, receiveByteLen - 4 - fNameLen);
                System.Threading.Thread.Sleep(2000);
                MessageCurrent = "Saving at: "+txbFileName;
                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public Client(string ipaddress, int port)//co tham so
        {
            IPAddress ip = IPAddress.Parse(ipaddress);
            end = new IPEndPoint(ip, port);
            //IPAddress ip = IPAddress.Parse("127.0.0.1");
            //end = new IPEndPoint(ip, 5000);
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //
            sock.Connect(end);//true
        }
        public void closeSocket()
        {
            sock.Close();
        }
        public  void SendFile(string fName,string convertType) //thay static
        {
            try
            {
                //Gui
                //IPAddress ip = IPAddress.Parse(ip1);
                //IPEndPoint end = new IPEndPoint(ip, port);
                //Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                ////
                //sock.Connect(end);
                // doan o tren bo?--
                int check = 0;
                check = sock.Send(Client.EncapFile(fName, convertType));
                while (true)
                {
                    if (check != 0)
                    {
                        byte[] serverData = new byte[1024 * 5000];
                        int receiveByteLen = sock.Receive(serverData);
                        Client.DecapFile(receiveByteLen, serverData);
                        //sock.Close();// khong close
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
