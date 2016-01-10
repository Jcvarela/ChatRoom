using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatRoom {
    class Program {
        static bool programContinues = true;
        static void Main( string[] args ) {

            Console.WriteLine("CHAT ROOM \n\n");

            while( programContinues ) {
                Console.WriteLine("Choose:");
                Console.WriteLine(" 1: to connect to server");
                Console.WriteLine(" 2: become server");
                Console.WriteLine("-1: to exit");

                int choice;

                try {
                    choice = int.Parse(Console.ReadLine());
                } catch( Exception ex ) {
                    choice = 0;
                }

                switch( choice ) {
                    case 1:
                        break;
                    case 2:
                        choice = Server();
                        break;
                    case -1:
                        programContinues = false;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\n\n\n");
            }
        }

        static int Server() {



            return 0;
        }
    }
}
