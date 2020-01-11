using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    class Program
    {
        private static void Main(string[] args)
        {
            //1 - Sum of Biggest Neighbor
            Console.WriteLine(new String('x', 40));
            Console.WriteLine("1 - Sum of Biggest Neighbor");
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Please enter the Numbers. After each number press enter for next Number.");
            Console.WriteLine("Press 'X' or 'x' once you finished entering the Numbers.");
            string InpChr = String.Empty;
            SumBigNeigbour sbn = new SumBigNeigbour();
            List<int> Input = new List<int>();
            bool ExitLoop = true;
            while (ExitLoop)
            {
                int ArrayNumber;
                InpChr = Console.ReadLine();
                if (Int32.TryParse(InpChr, out ArrayNumber))
                    Input.Add(ArrayNumber);
                else if (InpChr.ToUpper() == "X")
                    ExitLoop = false;
                else
                    Console.WriteLine("This is not a valid number");
            }
            Console.WriteLine("[" + String.Join<int>(", ", Input) + "]");
            Console.WriteLine("The result Of Challenge is: " + sbn.Challenge(Input.ToArray()).ToString());
            Console.WriteLine(new String('x', 40));

            //2 - User Class
            Console.WriteLine("2 - User Class");
            Console.WriteLine(new String('-', 40));
            while (true)
            {
                var user = new User();
                Console.WriteLine("please enter the username, or q to exit");
                var userName = Console.ReadLine();
                if (userName == "q")
                {
                    break;
                }
                user.Add(userName);
                Console.WriteLine($"number of addedUser { user.GetUsersCount()}");
            }
            Console.WriteLine(new String('x', 40));

            //3 - John the Robot
            Console.WriteLine("3 - John the Robot");
            Console.WriteLine(new String('-', 40));
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill()); //print dancing
            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());//print cooking
            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());//print no skill is defined
            Console.WriteLine(new String('x', 40));

            //4 - Alexa Settings
            Console.WriteLine("4 - Alexa Settings");
            Console.WriteLine(new String('-', 40));
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa
            alexa.Configure(x =>
            {
                x.GreetingMessage = " Hello {OwnerName}, I'm at your service ";
                x.OwnerName = " Bob Marley ";
            });
            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service
            Console.WriteLine(" press any key to exit ... ");
            Console.ReadKey();
            Console.WriteLine(new String('x', 40));

            //6 - Construction Game
            Console.WriteLine("6 - Construction Game");
            Console.WriteLine(new String('-', 40));

            var myHouse = new Building().AddKitchen().AddBedroom("master").AddBedroom("guest").AddBalcony();
            var normalHouse = myHouse.Build();
            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());
            myHouse.AddKitchen().AddBedroom(" another ");
            var luxuryHouse = myHouse.Build();
            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());
            Console.WriteLine(new String('x', 40));
            Console.Read();
        }


    }
    public class SumBigNeigbour
    {
        public int Challenge(int[] input)
        {
            int result = 0;
            var DuplicateValues = input.GroupBy(v => v).Where(cnt => cnt.Count() > 1).Select(s => s.Key);
            if (DuplicateValues.Count() >= 1)
            {
                var LargestValue = DuplicateValues.Max();
                int indx = Array.IndexOf(input, LargestValue);
                result = input[indx] + input[indx + 1];
            }
            return result;
        }
    }
}
