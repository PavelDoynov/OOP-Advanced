using System;
using System.Collections.Generic;
using System.Linq;

namespace Extended_Database
{
    public class Database
    {
        private const int ARR_LENGHT = 16;
        private Person[] arrDatabase;
        private int index;

        private Database()
        {
            this.arrDatabase = new Person[ARR_LENGHT];
            this.index = 0;
        }

        public Database(params Person[] persons)
            :this()
        {
            this.GetValues(persons);
        }

        private void GetValues(Person[] persons)
        {
            if (persons.Length <= ARR_LENGHT)
            {
                foreach (var person in persons)
                {
                    if (this.PersonIsNotExist(person))
                    {
                        this.arrDatabase[this.index] = person;
                        this.index++;
                    }
                    else
                    {
                        throw new InvalidOperationException("The person already exist.");
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Too many elements!");
            }
        }

        public void Add(Person person)
        {
            if (this.index >= ARR_LENGHT)
            {
                throw new InvalidOperationException("Array is full!");
            }

            if (this.PersonIsNotExist(person))
            {
                this.arrDatabase[this.index] = person;
                this.index++;
            }
            else
            {
                throw new InvalidOperationException("The person already exist.");
            }
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Array is empty!");
            }
            else
            {
                this.index--;
                this.arrDatabase[index] = default(Person);
            }
        }

        public Person[] Fetch()
        {
            Person[] newArr  = new Person[this.index];

            for (int i = 0; i < this.index; i++)
            {
                newArr[i] = this.arrDatabase[i];
            }

            return newArr;
        }

        public Person FindByUsername (string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Parameter is empty!");
            }

            List<string> names = new List<string>();
            for (int i = 0; i < this.index; i++)
            {
                names.Add(this.arrDatabase[i].Name);
            }

            if (names.Contains(name))
            {
                return this.arrDatabase.First(p => p.Name == name);
            }
            else
            {
                throw new InvalidOperationException("There is no such person!");
            }
        }

        public Person FindById (long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("ID can't be negative");
            }

            List<long> ids = new List<long>();
            for (int i = 0; i < this.index; i++)
            {
                ids.Add(this.arrDatabase[i].ID);
            }

            if (ids.Contains(id))
            {
                return this.arrDatabase.First(p => p.ID == id);
            }
            else
            {
                throw new InvalidOperationException("There is no such person!");
            }
        }

        private bool PersonIsNotExist(Person person)
        {
            List<long> ids = new List<long>();
            List<string> names = new List<string>();

            for (int i = 0; i < this.index; i++)
            {
                ids.Add(this.arrDatabase[i].ID);
                names.Add(this.arrDatabase[i].Name);
            }

            if (ids.Contains(person.ID) || names.Contains(person.Name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
