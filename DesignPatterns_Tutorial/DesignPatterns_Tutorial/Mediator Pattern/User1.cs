using System;

namespace DesignPatterns_Tutorial.Mediator_Pattern
{
    public class User1:User
    {
        private readonly Mediator _mediator;

        public User1(Mediator mediator)
        {
            _mediator = mediator;
            _mediator.RegisterUser(this);
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine("Sent by user 1 : " + message);
            _mediator.Send(message,this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine("Received by user 1..."+message);
        }
    }
}