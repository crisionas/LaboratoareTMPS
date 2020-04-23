using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Labs.Singletone
{
    public class Session
    {
        static Random rand1 = new Random();
        private Session() { }
        public string Token = null;
        private static Session _session = null;

        public static Session SessionObject(string login, string password)
        {

            _session = new Session();
            _session.Token = RandomUtil.GetRandomString();
            System.IO.File.AppendAllText(@"C:\Users\User\Documents\Session\sessions.txt", _session.Token);
            return _session;
        }

        public static bool IsSession(string login, string password)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\Users\User\Documents\Session\sessions.txt"))
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == _session.Token)
                        {
                            return true;
                        }
                    }
                }
            }
            catch { }

            return false;
        }
    }
}
