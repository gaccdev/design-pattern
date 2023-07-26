using Strategy;
using Strategy.Behaviors;

var ducks = new List<Duck>
{
    new MallardDuck(new FlyWithWings(), new Quack()),
    new RubberDuck(new FlyNoWay(), new MuteQuack())
};

foreach (var duck in ducks)
{
    duck.Display();
    duck.Swin();
    duck.PerformFly();
    duck.PerformQuack();

    Console.WriteLine();
}

Console.Read();

