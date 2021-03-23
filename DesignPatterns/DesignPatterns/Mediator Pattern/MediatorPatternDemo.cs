namespace DesignPatterns.Mediator_Pattern
{
    public class MediatorPatternDemo: DesignPatternDemo
    {
        public override void Show()
        {
            Mediator mediator = new Mediator();
            var userOne = new User("John",mediator);
            var userTwo = new User("Brian",mediator);
            var userThree = new User("Martin",mediator);
            userOne.SendMessage("Hi");
        }
    }
}