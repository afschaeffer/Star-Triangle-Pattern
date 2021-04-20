// Amy Shaeffer
// Displays a triangle made of stars with the number of starts in each row displayed at the end of the row.

using System;
class Program
{


    static void Main(string[] args)
    {
        int num1 = 2;
        int star_num = 2;
        
        while (num1 <= 20)
        {
            for (star_num = 2; star_num <= num1; star_num +=2 )
            {
                Console.Write("*");
            }
            Console.WriteLine(num1);
            num1 += 2;
        }

        Console.WriteLine();

        num1 = 20;

        while (num1 >= 2)
        {
            for (star_num = 2; star_num <= num1; star_num +=2 )
            {
                Console.Write("*");
            }
            Console.WriteLine(num1);
            num1 -= 2;
        }
    }
}

            
         
        


                    

        
    
