namespace DesignPatterns_Tutorial.Mediator_Pattern
{
    public class MediatorDemo
    {
        public void ShowDemo()
        {
            Mediator mediator = new Mediator();
            var user1 = new User1(mediator);
            var user2 = new User2(mediator);
            var user3 = new User3(mediator);
            user1.SendMessage("Hi");
        }
    }
}