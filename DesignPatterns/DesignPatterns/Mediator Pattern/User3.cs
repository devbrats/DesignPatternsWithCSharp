using System;

namespace DesignPatterns.Mediator_Pattern
{
    public class User3 : User
    {
        private readonly Mediator _mediator;

        public User3(Mediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterUser(this);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("Sent by User 3 : " + message);
            _mediator.Send(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Received by User 3..." + message);
        }
    }
}