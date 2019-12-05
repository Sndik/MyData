using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyData
{
    class Program

    {
        static void Main(string[] rags)
        {
            string stringFullNames, stringDate, stringAddresses;

             string surname = "Poghosyan";
              string name = "Artur";
               string patronymic = "Robertovich";

            stringFullNames = surname + " " + name +" " + patronymic;
            
             int age = 34;
              double weight = 83.5;
       
            stringDate = " возрост " + age + " вес " + weight;

            string country = "Ukraine";
              string region = "Odessa";
               string locality = "Kamianka";
                string street = "Central";
                 int house = 21;
                  string phone = "+38(096)584 22 54";

            stringAddresses = " Страна " + country + ", Область " + region + ", Населённый путк " + locality + ", Улица " + street + ", Дом " + house + " Тел. " + phone;


            System.Console.WriteLine(stringFullNames);

            System.Console.WriteLine(stringDate.Trim());

            System.Console.WriteLine(stringAddresses.Trim());

            System.Console.ReadLine();

        }
    }
}
