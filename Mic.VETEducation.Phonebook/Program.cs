using System;

namespace Mic.VETEducation.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary___
            //var phonebook = new Phonebook();

            //phonebook.AddPeople("Hayk Khachatryan", 123456789);
            //phonebook.AddPeople("Gor", 123456789);
            //phonebook.AddPeople("Vazgen", 123456789);
            //phonebook.AddPeople("Miqayel", 123456789);
            //phonebook.AddPeople("Arame", 123456789);
            //phonebook.AddPeople("Albert", 123456789);
            //phonebook.AddPeople("Edmon", 123456789);
            //phonebook.AddPeople("Hayk", 123456789);
            //phonebook.AddPeople("Hayk", 123456789);

            //phonebook.GetPersonNumber("Hayk");
            //phonebook.GetPeopleList();
            //Console.WriteLine();
            //phonebook.RemovePeople("Hayk Khachatryan");
            //phonebook.RemovePeople("Albert");
            //phonebook.GetPeopleList();


            //IEnumerable___
            var root = new People { Nickname = "Hayk", PhoneNumber = 123456789 };

            root.AddPeople("Hayk Khachatryan", 123456789);
            root.AddPeople("Gor", 123456789);
            root.AddPeople("Vazgen", 123456789);
            root.AddPeople("Miqayel", 123456789);
            root.AddPeople("Arame", 123456789);
            root.AddPeople("Albert", 123456789);
            root.AddPeople("Edmon", 123456789);
            root.AddPeople("Hayk", 123456789);

            root.GetPersonNumber("Hayk Khachatryan");
            Console.WriteLine();
            root.GetPeopleList();
            Console.WriteLine();
            //root.RemovePeople("Hayk Khachatryan");
            //root.RemovePeople("Albert");
            //root.GetPeopleList();
        }
    }
}
