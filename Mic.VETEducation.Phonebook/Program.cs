using System;

namespace Mic.VETEducation.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary___
            var phonebook1 = new Phonebook1();

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

            phonebook1.GetPersonNumber("Hayk");
            phonebook1.GetPersonNumber("UnavailableName");
            Console.WriteLine();

            Console.WriteLine("Old List");
            phonebook1.GetPeopleList();
            Console.WriteLine();

            phonebook1.RemovePeople("Hayk Khachatryan");
            phonebook1.RemovePeople("Albert");
            phonebook1.RemovePeople("UnavailableName");
            Console.WriteLine("New List");
            phonebook1.GetPeopleList();

            Console.WriteLine(new string('-',23));
            //IEnumerable___

            var phonebook2 = new Phonebook2 { Nickname = "Hayk Khachatryan", PhoneNumber = 11111111 };

            phonebook2.AddPeople("Gor", 22222222);
            phonebook2.AddPeople("Vazgen", 33333333);
            phonebook2.AddPeople("Miqayel", 44444444);
            phonebook2.AddPeople("Arame", 55555555);
            phonebook2.AddPeople("Albert", 66666666);
            phonebook2.AddPeople("Edmon", 77777777);
            phonebook2.AddPeople("Hayk", 88888888);
            phonebook2.AddPeople("Hayk", 99999999);
            Console.WriteLine();

            phonebook2.GetPersonNumber("Hayk");
            phonebook2.GetPersonNumber("UnavailableName");
            Console.WriteLine();

            Console.WriteLine("Old List");
            phonebook2.GetPeopleList();
            Console.WriteLine();

            phonebook2.RemovePeople("Hayk Khachatryan");
            phonebook2.RemovePeople("Albert");
            phonebook2.RemovePeople("UnavailableName");
            Console.WriteLine("New List");
            phonebook2.GetPeopleList();

        }
    }
}