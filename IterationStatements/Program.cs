namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintAllNums();
            Console.WriteLine();

            PrintAllThrees();
            Console.WriteLine();

            //IsItEqual(54, 54);
            Console.WriteLine(IsItEqual(54, 54));
            Console.WriteLine();

            OddsOrEvens(45);
            Console.WriteLine();

            IsPosOrNeg(-1);
            Console.WriteLine();

            CanTheyVote();
            Console.WriteLine();

            IsRangeTen(8);
            Console.WriteLine();

            MultTable12(6);
            Console.WriteLine();


        }

        public static void PrintAllNums()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }    
        }

        public static void PrintAllThrees()
        {
            for (int triple = 3; triple <= 999; triple += 3)
            {
                Console.WriteLine(triple);
            }
        }

        public static bool IsItEqual(int equal1, int equal2)
        {
            var isIt = (equal1 == equal2) ? true : false;
            return isIt;
        }

        public static void OddsOrEvens(int oddEvenInt)
        {
            if (oddEvenInt % 2 == 0)
            {
                
                Console.WriteLine($"{oddEvenInt} is an even number.");
                
            }

            else
            {
                Console.WriteLine($"{oddEvenInt} is an odd number.");
            }
        }

        public static void IsPosOrNeg(int posNeg)
        {
            if (posNeg > 0)
            {
                Console.WriteLine($"{posNeg} is a positive number.");
            }
            else if (posNeg < 0)
            {
                Console.WriteLine($"{posNeg} is a negative number.");
            }
            else
            {
                Console.WriteLine($"{posNeg} is neither positive or negative.");
            }
        }
        public static bool CanTheyVote()
        {
            Console.WriteLine("Please enter your age.");
            var voterAge = int.TryParse(Console.ReadLine(), out int ageVoter);

            while(voterAge == false)
            {
                Console.WriteLine("Please enter a valid age.");
                voterAge = int.TryParse(Console.ReadLine(), out ageVoter);
            }

            if (ageVoter >= 18)
            {
                Console.WriteLine("Here is your ballot. Please proceeed to an open booth.");
                return true;
            }
            else
            {
                Console.WriteLine("You are not old enough to vote yet.");
                return false;
            }
        }
        public static bool IsRangeTen(int numTen)
        {
            if(numTen <= 10 && numTen >= -10)
            {
                Console.WriteLine($"{numTen} is within the ten range.");
                return true;
            }
            else
            {
                Console.WriteLine($"{numTen} is outside of the ten range.");
                return false;
            }
        }

        public static void MultTable12(int prod12)
        {
            for(int p=1; p <=12; p++) 
            {
                Console.WriteLine($"{p} x {prod12} = {p * prod12}");
            }
        }

    }
}
