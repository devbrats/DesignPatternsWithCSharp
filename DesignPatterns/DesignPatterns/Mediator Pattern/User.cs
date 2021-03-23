using System;

namespace DesignPatterns.Mediator_Pattern
{
    public class User
    {
        private readonly Mediator _mediator;

        public User(string name, Mediator mediator)
        {
            Name = name;
            _mediator = mediator;
            _mediator.RegisterUser(this);
        }

        public string Name { get; }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name} : {message}");
            _mediator.Send(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Received by user {Name} : {message}");
        }
    }
}