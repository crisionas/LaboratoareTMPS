using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Singletone
{
    class Auth
    {
        public void Login()
        {
            LiveStreaming liveStreaming = LiveStreaming.GetInstance();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Username: ");
                string login = Console.ReadLine();
                Console.WriteLine("Password: ");
                string pass = Console.ReadLine();


                if (Session.IsSession(login, pass))
                {
                    Console.WriteLine("An session already exist.");
                }
                else if (liveStreaming.GetSession(login, pass) != null)
                {
                    Session _session = liveStreaming.GetSession(login, pass);
                    Console.WriteLine("You are logged successful.");

                }
                else
                {
                    Console.WriteLine("Username or password are incorrect.");

                }
            }
        }
        public void Logoff()
        {
            LiveStreaming liveStreaming = LiveStreaming.GetInstance();
            liveStreaming.GetSession(pass: null, login: null);
        }
    }
}
