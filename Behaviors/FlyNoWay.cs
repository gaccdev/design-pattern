namespace DesignPattern.Behaviors
{
	public class FlyNoWay: IFlyBehavior
	{
        public void Fly()
        {
            Console.WriteLine("Cannot Fly");
        }
    }
}

