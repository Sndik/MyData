using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData
{
    class Program

    {
       static void Main(string[] args)
        {
            string stringMyData1, stringMyDate2;

             string surname = "Poghosyan";
              string name = "Artur";
               string patronymic = "pogosyan";

            stringMyData1 = surname + " " + name +" " + patronymic;
            
             int age = 34;
              double weight = 83.5;
       
            stringMyDate2 = " возрост " + age + " вес " + weight;

            System.Console.WriteLine(stringMyData1);
            System.Console.WriteLine(stringMyDate2);

            System.Console.ReadLine();

        }
    }
}
