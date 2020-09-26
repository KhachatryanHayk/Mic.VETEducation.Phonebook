using System;
using System.Collections.Generic;

namespace Mic.VETEducation.Phonebook
{
    class Phonebook
    {
        private readonly Dictionary<string, int> _phoneBook = new Dictionary<string, int>();

        public void AddPeople(string nickname, int phoneNumber)
        {
            try
            {
                _phoneBook.Add(nickname, phoneNumber);
            }
            catch (Exception)
            {
                Console.WriteLine($"You already have a person named {nickname} in your phone book.");
            }
        }
        public void RemovePeople(string nickname)
        {
            _phoneBook.Remove(nickname);
        }
        public void PrintPersonNumber(string nickname)
        {
            try
            {
                Console.WriteLine($"{nickname} : +374{_phoneBook[nickname]}");
            }
            catch (Exception)
            {
                Console.WriteLine($"There is no man named {nickname} in your phone book");
            }
        }
        public void PrintPeopleList()
        {
            foreach (var people in _phoneBook)
            {
                Console.WriteLine($"{people.Key} : +374{people.Value}");
            }
        }
    }
}