namespace Strategy
{
	public abstract class Duck
	{
		private readonly IFlyBehavior _flyBehavior;
		private readonly IQuackBehavior _quackBehavior;

		protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
		{
			_flyBehavior = flyBehavior;
			_quackBehavior = quackBehavior;
        }

		public abstract void Swin();
		public abstract void Display();
		public void PerformQuack() => _quackBehavior.Quack();
		public void PerformFly() => _flyBehavior.Fly();
    }
}

