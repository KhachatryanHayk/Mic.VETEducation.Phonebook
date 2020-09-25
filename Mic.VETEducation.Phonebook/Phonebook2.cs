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

            if (Next == null)
            {
                Next = new Phonebook2 { Nickname = Nickname, PhoneNumber = PhoneNumber };
                return Next;
            }

            Next.AddPeople(Nickname, PhoneNumber);
            return Next;
        }
        public void RemovePeople(string Nickname)
        {
            Phonebook2 current = GetByNickname(Nickname);
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
        private Phonebook2 GetByNickname(string Nickname)
        {
            Phonebook2 current = this;

            while (true)
            {
                if (current.Nickname == Nickname)
                    break;
                current = current.Next;
            }
            return current;
        }
        public void GetPersonNumber(string Nickname)
        {
            Phonebook2 Temp = this;
            GetByKey(Nickname, ref Temp);

            Console.WriteLine($"{Nickname} : +374{Temp.PhoneNumber}");
        }
        public void GetPeopleList()
        {
            Console.WriteLine($"{Nickname} : +374{PhoneNumber}");
            if (Next != null)
                Next.GetPeopleList();
        }
        private void GetByKey(string Nickname, ref Phonebook2 people)
        {
            if (this.Nickname == Nickname)
            {
                people = this;
            }
            else
            {
                Next.GetByKey(Nickname, ref people);
            }
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