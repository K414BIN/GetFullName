using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int names = 4;
            string[] fName = new string[names] { "Василий", "Андрей", "Николай", "Александр" };
            string[] lName = new string[names] { "Боширов", "Чепига", "Навальный", "Смирнов" };
            string[] dadName = new string[names] { "Олегович", "Николаевич", "Семенович", "Петрович" };
            for (int j = 0; j < names; j++)
            {
                Console.WriteLine(GetFullName(fName[j], lName[j], dadName[j]));
            }
            Console.ReadLine();
        }
        static string GetFullName(string firstName, string lastName, string patronymic) 
        { 
            string str;
            str = firstName+" " +  patronymic +" "+ lastName;
            return str;
        }
    }
}
