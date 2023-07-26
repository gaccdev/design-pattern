namespace Strategy.Behaviors
{
    public class MuteQuack: IQuackBehavior
	{		
        public void Quack()
        {
            Console.WriteLine("No Quacking");
        }
    }
}

