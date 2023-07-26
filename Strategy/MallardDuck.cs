namespace Strategy
{
    public class MallardDuck:Duck
	{
		public MallardDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
            : base(flyBehavior, quackBehavior)
		{
		}

        public override void Display()
        {
            Console.WriteLine("MallardDuck");
        }

        public override void Swin()
        {
            Console.WriteLine("MallardDuck Swimming");
        }
    }
}

