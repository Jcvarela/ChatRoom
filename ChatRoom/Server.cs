﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatRoom {
    class Server {



        Server() {
            Console.WriteLine(GetLocalIPAddress());
        }



        public static string GetLocalIPAddress() {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach( var ip in host.AddressList ) {
                if( ip.AddressFamily == AddressFamily.InterNetwork ) {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

    }
}
