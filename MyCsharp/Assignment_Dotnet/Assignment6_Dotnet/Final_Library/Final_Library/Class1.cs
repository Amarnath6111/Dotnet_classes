using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Library
{
    public class Class1
    {
        
            public int Age { get; set; }
            public string Name { get; set; }
            public double TotalFare = 2000;
            public void CalculateConcession(int age)
            {
                int Age = age;
                if (Age <= 5)
                {
                    Console.WriteLine($"Name: {Name}  Age:{Age} \n Little Champs- Free Ticket");
                }
                else if (Age > 60)
                {
                    double Total = TotalFare -(TotalFare * 0.3);
                    Console.WriteLine($"Senior citizens will get a discount of 30%, hence final fare is {Total} \n Name: {Name}  Age: {Age}");
                }
                else
                {
                    Console.WriteLine($"Ticket booked \n Name: {Name} Age: {Age} Toatalfare: {TotalFare}");
                }
            }  
    }
}
