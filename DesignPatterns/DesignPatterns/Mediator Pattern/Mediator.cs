using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Mediator_Pattern
{
    public class Mediator
    {
        //private  User1 _user1;
        //private  User2 _user2;

        //public void RegisterUsers(User1 user1, User2 user2)
        //{
        //    this._user1 = user1;
        //    this._user2 = user2;
        //}

        private List<User> _users;

        public Mediator()
        {
            _users = new List<User>();
        }

        public void RegisterUser(User user)
        {
           _users.Add(user);
        }

        public void Send(string message, User user)
        {
            //if (user==this._user1)
            //{
            //    _user2.ReceiveMessage(message);
            //}
            //else
            //{
            //    _user1.ReceiveMessage(message);
            //}
            var receivers = _users.Where(x => x != user);
            foreach (var receiver in  receivers)
            {
                receiver.ReceiveMessage(message);
            }
        }
    }
}
