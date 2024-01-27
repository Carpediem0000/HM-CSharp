using Task1;
namespace HM_
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Task2 */

            int event_user = 0;
            User user = new User
            (
                "Boris",24,
                new string[] {"Morkva", "Kapusta", "Meet", "Milk"},
                new string[] {"Zaradka", "Run"},
                new string[] {"Gimnastika", "Baseyn"}
            );

            Console.WriteLine("Enter event: [1 = Kurit, 2 = Run, 3 = Ananas]");
            event_user = Int32.Parse(Console.ReadLine());
            switch (event_user)
            {
                case 1:
                    Console.WriteLine("Bad choose: {0}", user.Recommends(new Random().Next(0, 4)));
                    break;
                case 2:
                    Console.WriteLine(user.Recommends(new Random().Next(0, 4)));
                    break;
                case 3:
                    Console.WriteLine(user.Recommends(new Random().Next(0, 4)));
                    break;
                default:
                    Console.WriteLine("I don't know this command!");
                    break;
            }
            Console.WriteLine("######## Fisical ########");
            user.Print_fisical();
            Console.WriteLine("######## Privichka ########");
            user.Print_privichka();
            Console.WriteLine("######## Racion ########");
            user.Print_racion();

            Console.WriteLine("=======================================================");

            /* Task1 */

            Human human = new Human(
                    "Boris",
                    new Task1.Task[]
                    {
                        new Task1.Task("Купить телевизор!"),
                        new Task1.Task("Сделать дз"),
                        new Task1.Task("Сходить за продуктами")
                    },
                    new Goal[]
                    {
                        new Goal("Купить дом", new DateOnly(2030, 1, 27)),
                        new Goal("Поехать за границу", new DateOnly(2023, 11, 27)),
                        new Goal("Купить собаку", new DateOnly(2024, 1, 27))
                    }
                    );
            Console.WriteLine(human);

            human.RealiseTask(0);
            human.RealiseGoal(2);
            human.RemoveGoal(1);

            Console.WriteLine(human);
        }
    }
}
