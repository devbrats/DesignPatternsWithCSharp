using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Mediator_Pattern
{
    public class Mediator
    {
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
            var receivers = _users.Where(x => x != user);
            foreach (var receiver in  receivers)
            {
                receiver.ReceiveMessage(message);
            }
        }
    }
}
