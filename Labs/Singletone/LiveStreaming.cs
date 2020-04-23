
using Labs.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labs.Singletone
{
    public class LiveStreaming
    {

        public List<User> _users = new List<User>()
        {
            new User {Login = "admin", Password="admin"},
            new User {Login = "exempl", Password="exempl"},
        };

        private LiveStreaming() { }
        public static LiveStreaming GetInstance()
        {
            return new LiveStreaming();
        }

        public Session GetSession(string login, string pass)
        {

            foreach (var c in _users)
            {
                if (c.Login == login && c.Password == pass)
                    return Session.SessionObject(login, pass);
            }


            return null;

        }
    }
}
