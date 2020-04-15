using System;

namespace DesignPatterns_Tutorial.Mediator_Pattern
{
    public abstract class User
    {
        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string messsage);
    }
}