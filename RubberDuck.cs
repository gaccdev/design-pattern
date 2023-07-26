namespace DesignPattern
{
    public class RubberDuck : Duck
	{
		public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
		{
		}

        public override void Display()
        {
            Console.WriteLine("RubberDuck");
        }

        public override void Swin()
        {
            Console.WriteLine("RubberDuck Swimming");
        }
    }
}

