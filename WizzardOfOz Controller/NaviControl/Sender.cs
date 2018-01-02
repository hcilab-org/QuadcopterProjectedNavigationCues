using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NaviControl
{
    class Sender
    {

        private static Int32 port = 9876;

        public static void send(String text)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(text);

            if (Variables.BeamerActive)
            {
                TcpClient beamer = new TcpClient(Variables.BeamerIP, port);
                NetworkStream streamBeamer = beamer.GetStream();
                streamBeamer.WriteTimeout = 1000;
                streamBeamer.Write(data, 0, data.Length);
                streamBeamer.Close();
                beamer.Close();
            }

            TcpClient phone = new TcpClient(Variables.PhoneIP, port);
            NetworkStream streamPhone = phone.GetStream();
            streamPhone.WriteTimeout = 1000;
            streamPhone.Write(data, 0, data.Length);
            streamPhone.Close();
            phone.Close();
        }

        public void mirror_up()
        {
            string sURL;
            sURL = "http://192.168.240.1/arduino/85";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            wrGETURL.GetResponse();
        }

        public void mirror_down()
        {
            string sURL;
            sURL = "http://192.168.240.1/arduino/down";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);
            wrGETURL.GetResponse();
        }

    }
}
