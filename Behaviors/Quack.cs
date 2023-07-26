namespace DesignPattern.Behaviors
{
    public class Quack: IQuackBehavior
	{
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quacking");
        }
    }
}

