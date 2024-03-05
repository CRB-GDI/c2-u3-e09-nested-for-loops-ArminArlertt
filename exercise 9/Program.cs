using System.Security.Cryptography;

namespace exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                //PROBLEM 1
                //Prompt for row width 
                
                Console.Write("number of width:");
                int rowWidth = int.Parse (Console.ReadLine());
                Console.Write("enter number of rows: ");
                int numRows = int.Parse (Console.ReadLine());

                //print rows 
                Console.WriteLine();
                for (int i = 1 ; i <= numRows; i++)
                {
                    for (int j = 1 ; j <= rowWidth; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
           
        }
    }
}