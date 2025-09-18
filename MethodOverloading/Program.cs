namespace MethodOverloading
{
    public class Program
    {
        //define methods to overload
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        public static string Add(int numOne, int numTwo, bool checkIsTrue)
        {
            var sum = numOne + numTwo;
            
            if (checkIsTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (checkIsTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (checkIsTrue == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
            
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,2));
            Console.WriteLine(Add(2.0m,2.0m));
            Console.WriteLine(Add(6,3,true));
        }
    }
}
