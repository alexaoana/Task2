namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I am an animal and a mammal");
            Mammal mammal = new Mammal();
            mammal.Move();

            Console.WriteLine();
            Console.WriteLine("I am an animal and a reptile");
            Reptile reptile = new Reptile();
            reptile.Move();

            Console.WriteLine();
            Console.WriteLine("I am an animal and a bird");
            Bird bird = new Bird();
            bird.Move();

            Console.WriteLine();
            Console.WriteLine("I am an animal, a bird and a duck");
            Duck duck = new Duck();
            duck.Move();
            duck.Move(10);

            Console.WriteLine();
            Console.WriteLine("I am an animal, a mammal and a lion");
            Lion lion = new Lion();
            lion.Move();
            lion.Move(40);

            Console.WriteLine();
            Console.WriteLine("I am an animal, a reptile and a snake");
            Snake snake = new Snake();
            snake.Move();
            snake.Move(20);
        }
    }
}
