using System;
using System.Collections.Generic;

namespace Mic.VETEducation.Phonebook
{
    class Phonebook1
    {
        private Dictionary<string, int> phonebook = new Dictionary<string, int>();

        public void AddPeople(string Nickname, int Phonenumber)
        {
            try
            {
                phonebook.Add(Nickname, Phonenumber);
            }
            catch (Exception)
            {
                Console.WriteLine($"You already have a person named {Nickname} in your phone book.");
            }
        }
        public void RemovePeople(string Nickname)
        {
            phonebook.Remove(Nickname);
        }
        public void GetPersonNumber(string Nickname)
        {
            try
            {
                Console.WriteLine($"{Nickname} : +374{phonebook[Nickname]}");
            }
            catch (Exception)
            {
                Console.WriteLine($"There is no man named {Nickname} in your phone book");
            }
        }
        public void GetPeopleList()
        {
            foreach (var People in phonebook)
            {
                Console.WriteLine($"{People.Key} : +374{People.Value}");
            }
        }
    }
}