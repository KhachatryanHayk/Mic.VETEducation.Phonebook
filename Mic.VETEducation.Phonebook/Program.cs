using System;
using System.Collections.Generic;

namespace Mic.VETEducation.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary___
            var phonebook1 = new Phonebook();

            phonebook1.AddPeople("Hayk Khachatryan", 11111111);
            phonebook1.AddPeople("Gor", 22222222);
            phonebook1.AddPeople("Vazgen", 33333333);
            phonebook1.AddPeople("Miqayel", 44444444);
            phonebook1.AddPeople("Arame", 55555555);
            phonebook1.AddPeople("Albert", 66666666);
            phonebook1.AddPeople("Edmon", 77777777);
            phonebook1.AddPeople("Hayk", 88888888);
            phonebook1.AddPeople("Hayk", 99999999);
            Console.WriteLine();

            phonebook1.PrintPersonNumber("Hayk");
            phonebook1.PrintPersonNumber("UnavailableName");
            Console.WriteLine();

            Console.WriteLine("Old List");
            phonebook1.PrintPeopleList();
            Console.WriteLine();

            phonebook1.RemovePeople("Hayk Khachatryan");
            phonebook1.RemovePeople("Albert");
            phonebook1.RemovePeople("UnavailableName");
            Console.WriteLine("New List");
            phonebook1.PrintPeopleList();
        }
    }
}
