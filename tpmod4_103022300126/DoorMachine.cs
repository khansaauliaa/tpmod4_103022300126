using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod4_103022300126

{
        class DoorMachine
        {
            enum State { terkunci, terbuka, keluar };
            public void door()
            {
                State state = State.terkunci;
                String[] status = { "terkunci", "terbuka", "keluar" };

                while (state != State.keluar)
                {

                    Console.WriteLine("\n" + "Pintu " + status[(int)state] + "\n");
                    Console.WriteLine("Masukkan perintah (masukkan keluar untuk kembali) : ");
                    String command = Console.ReadLine();

                    switch (state)
                    {
                        case State.terkunci:
                            if (command == "buka")
                            {
                                state = State.terbuka;
                            }
                            else if (command == "keluar")
                            {
                                Program.Main();

                            }
                            break;
                        case State.terbuka:
                            if (command == "kunci")
                            {
                                state = State.terkunci;
                            }
                            else if (command == "keluar")
                            {
                                Program.Main();
                            }
                            break;
                    }
                }
            }
        }

    }
