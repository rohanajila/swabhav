using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;   
            Console.Write("\n Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;    
                num = num / 10;   
                sum = sum * 10 + rem;
                
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum)     
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
        }
    }
}
