namespace Strategy.Behaviors
{
	public class FlyNoWay: IFlyBehavior
	{
        public void Fly()
        {
            Console.WriteLine("Cannot Fly");
        }
    }
}

