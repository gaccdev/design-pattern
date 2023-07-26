namespace Strategy.Behaviors
{
    public class Quack: IQuackBehavior
	{
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quacking");
        }
    }
}

