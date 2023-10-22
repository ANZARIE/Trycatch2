
namespace TryCatch2
{
    public class TryCatch
    {
        static void Main(string[] args)
        {  
           try
           {
                Console.WriteLine("Enter starting number");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter end number");
                int end = Convert.ToInt32(Console.ReadLine());

                
                if(start>=end)
                {
                    throw new ArgumentOutOfRangeException("Out of Range!");
                }
                int input = end - start;
                if(input != 10)
                {
                    throw new ArgumentOutOfRangeException("End minus Start must be equal to 10");
                }
            ReadNumber(start,end);
           }
           catch(Exception ex)
           {
                Console.WriteLine($"Normal exception. {ex.Message}");
           }
           
        }

        class AnzarieException : Exception
        {
            public AnzarieException() { }
            public AnzarieException(string message) : base(message) { }
            public AnzarieException(string message, Exception inner) : base(message,
            inner) { }
        }
        static void ReadNumber(int start, int end)
        {
            try
            {
                int[] numbers = new int[10];
                for(int x = 0; x < numbers.Length; x++)
                {
                    Console.WriteLine($"Enter an Integer {x+1}");
                    numbers[x] = Convert.ToInt32(Console.ReadLine());
                   
                    if(numbers[x] <= start || numbers[x] >= end)
                    {
                        throw new AnzarieException($"Number must be greater than {start} and number must be less than {end} sabi ni Anzarie");
                    }
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Invalid number. {ex.Message}");
            }
        }
    }
}