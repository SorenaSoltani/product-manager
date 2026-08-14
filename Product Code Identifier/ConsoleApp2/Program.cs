using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp2.domain;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                product soda = new product();
                soda.stock = 99;
                soda.productName = "nooshabe";
                soda.price = 111.500;

                product chips = new product();
                chips.stock = 99;
                chips.productName = "chips";
                chips.price = 70.000;

                Console.WriteLine("Enter Product Code");
                int ProductCode = int.Parse(Console.ReadLine());
                if (ProductCode == 1)
                {
                    Console.WriteLine("product name :" + soda.productName);
                    Console.WriteLine("product stock :" + (soda.stock));
                    Console.WriteLine("product price :" + soda.price);
                    Console.WriteLine("");
                    
                }
                else if(ProductCode == 2)
                {
                    Console.WriteLine("product name :" + chips.productName);
                    Console.WriteLine("product stock :" + (chips.stock));
                    Console.WriteLine("product price :" + chips.price);
                    Console.WriteLine(""); 
                }
            }
            
            
            
            Console.ReadLine();
        }
       
    }
}
