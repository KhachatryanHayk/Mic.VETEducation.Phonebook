using System;
using System.Collections;

namespace Mic.VETEducation.Phonebook
{
    class Phonebook2 : IEnumerable
    {
        public string Nickname { get; set; }
        public int PhoneNumber { get; set; }
        public Phonebook2 Next;

        public Phonebook2 AddPeople(string Nickname, int PhoneNumber)
        {
            if (GetByNickname(Nickname) == null)
            {
                if (Next == null)
                {
                    Next = new Phonebook2 { Nickname = Nickname, PhoneNumber = PhoneNumber };
                    return Next;
                }

                Next.AddPeople(Nickname, PhoneNumber);
                return Next;
            }
            Console.WriteLine($"You already have a person named {Nickname} in your phone book.");
            return Next;
        }
        public void RemovePeople(string Nickname)
        {
            Phonebook2 current = GetByNickname(Nickname);
            if (current != null)
            {
                current.Nickname = null;

                while (true)
                {
                    current.Nickname = current.Next.Nickname;
                    current.PhoneNumber = current.Next.PhoneNumber;
                    if (current.Next.Next != null)
                        current = current.Next;
                    else
                        break;
                }
                current.Next = null;
            }
        }
        private Phonebook2 GetByNickname(string Nickname)
        {
            Phonebook2 current = this;
            bool answer = false;

            while (true)
            {
                if (current.Nickname == Nickname)
                {
                    answer = true;
                    break;
                }
                if (current.Next != null)
                    current = current.Next;
                else
                    break;
            }
            if (!answer)
                current = null;
            return current;
        }
        public void GetPersonNumber(string Nickname)
        {
            Phonebook2 Temp = GetByNickname(Nickname);

            if (Temp != null)
                Console.WriteLine($"{Nickname} : +374{Temp.PhoneNumber}");
            else
                Console.WriteLine($"There is no man named {Nickname} in your phone book");
        }
        public void GetPeopleList()
        {
            Console.WriteLine($"{Nickname} : +374{PhoneNumber}");
            if (Next != null)
                Next.GetPeopleList();
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
        private class Enumerator : IEnumerator
        {
            private Phonebook2 _root;
            public Enumerator(Phonebook2 root)
            {
                _root = root;
            }
            public object Current { get; private set; }
            public bool MoveNext()
            {
                if (_root == null)
                    return false;

                Current = _root.Nickname;
                _root = _root.Next;

                return true;
            }
            public void Reset()
            {
                _root = null;
            }
        }
    }
}