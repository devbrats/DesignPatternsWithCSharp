using System;

namespace DesignPatterns_Tutorial.Mediator_Pattern
{
    public class User2:User
    {
        private readonly Mediator _mediator;

        public User2(Mediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterUser(this);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("Sent by User 2 : " + message);
            _mediator.Send(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Received by User 2..." + message);
        }
    }
}