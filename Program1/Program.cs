using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateQuestion("Last Name");
            string last = Console.ReadLine();

            CreateQuestion("First Name");
            string first = Console.ReadLine();

            CreateQuestion("Age");
            int age = 0;
            int.TryParse(Console.ReadLine(), out age);

            CreateQuestion("Street");
            string street = Console.ReadLine();

            CreateQuestion("ZIP Code");
            string zip = Console.ReadLine();

            CreateQuestion("Phone Number");
            string phone = Console.ReadLine();

            CreateQuestion("E-Mail Address");
            string email = Console.ReadLine();

            Console.WriteLine("\nYour information: \n");

            LabelAndSend("Name", first, last);
            LabelAndSend("Age", age.ToString());
            LabelAndSend("Street", street);
            LabelAndSend("ZIP Code", zip);
            LabelAndSend("Phone Number", phone);
            LabelAndSend("E-Mail Address", email);

            Console.ReadLine();
        }

        static void CreateQuestion(string topic)
        {
            WriteLine("What is your " + topic + "?");
        }
        
        static void LabelAndSend(string topic, string info)
        {
            WriteLine(topic + ": " + info);
        }

        static void LabelAndSend(string topic, string first, string last)
        {
            WriteLine(topic + ": " + last + ", " + first);
        }
    }
}
