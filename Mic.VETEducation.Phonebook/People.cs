using System;
using System.Collections;

namespace Mic.VETEducation.Phonebook
{
    class People : IEnumerable
    {
        public string Nickname { get; set; }
        public int PhoneNumber { get; set; }
        public People Next;

        public People AddPeople(string Nickname, int PhoneNumber)
        {
                if (Next == null)
                {
                    Next = new People { Nickname = Nickname, PhoneNumber = PhoneNumber };
                    return Next;
                }

                Next.AddPeople(Nickname, PhoneNumber);
                return Next;
        }
        public void RemovePeople(string Nickname)
        {
            //...
        }
        public void GetPersonNumber(string Nickname)
        {
            People Temp = this;
            GetByKey(Nickname, ref Temp);

            Console.WriteLine($"{Nickname} : +374{Temp.PhoneNumber}");
        }
        public void GetPeopleList()
        {
            Console.WriteLine($"{Nickname} : +374{PhoneNumber}");
            if (Next != null)
                Next.GetPeopleList();
        }
        private void GetByKey(string Nickname, ref People people)
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
            private People _root;


            public Enumerator(People root)
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