using System;

namespace Mic.VETEducation.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary___
            var phonebook1 = new Phonebook1();

            phonebook1.AddPeople("Hayk Khachatryan", 123456789);
            phonebook1.AddPeople("Gor", 123456789);
            phonebook1.AddPeople("Vazgen", 123456789);
            phonebook1.AddPeople("Miqayel", 123456789);
            phonebook1.AddPeople("Arame", 123456789);
            phonebook1.AddPeople("Albert", 123456789);
            phonebook1.AddPeople("Edmon", 123456789);
            phonebook1.AddPeople("Hayk", 123456789);
            phonebook1.AddPeople("Hayk", 123456789);
            Console.WriteLine();

            phonebook1.GetPersonNumber("Hayk");
            phonebook1.GetPersonNumber("UnaviableName");
            Console.WriteLine();

            Console.WriteLine("Old List");
            phonebook1.GetPeopleList();
            Console.WriteLine();

            phonebook1.RemovePeople("Hayk Khachatryan");
            phonebook1.RemovePeople("Albert");
            phonebook1.RemovePeople("UnaviableName");
            Console.WriteLine("New List");
            phonebook1.GetPeopleList();

            Console.WriteLine(new string('-',23));
            //IEnumerable___

            var phonebook2 = new Phonebook2 { Nickname = "Hayk Khachatryan", PhoneNumber = 123456789 };

            phonebook2.AddPeople("Gor", 123456789);
            phonebook2.AddPeople("Vazgen", 123456789);
            phonebook2.AddPeople("Miqayel", 123456789);
            phonebook2.AddPeople("Arame", 123456789);
            phonebook2.AddPeople("Albert", 123456789);
            phonebook2.AddPeople("Edmon", 123456789);
            phonebook2.AddPeople("Hayk", 123456789);
            phonebook2.AddPeople("Hayk", 123456789);
            Console.WriteLine();

            phonebook2.GetPersonNumber("Hayk");
            phonebook2.GetPersonNumber("UnaviableName");
            Console.WriteLine();

            Console.WriteLine("Old List");
            phonebook2.GetPeopleList();
            Console.WriteLine();

            phonebook2.RemovePeople("Hayk Khachatryan");
            phonebook2.RemovePeople("Albert");
            phonebook2.RemovePeople("UnaviableName");
            Console.WriteLine("New List");
            phonebook2.GetPeopleList();
        }
    }
}