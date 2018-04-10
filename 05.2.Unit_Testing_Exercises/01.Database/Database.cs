using System;

namespace Database
{
    public class Database
    {
        private const int ARR_LENGHT = 16;
        private int[] arrDatabase;
        private int index;

        private Database()
        {
            this.arrDatabase = new int[ARR_LENGHT];
            this.index = 0;
        }

        public Database(params int[] numbers)
            :this()
        {
            this.GetValues(numbers);
        }

        private void GetValues(int[] numbers)
        {
            if (numbers.Length <= ARR_LENGHT)
            {
                foreach (var number in numbers)
                {
                    this.arrDatabase[this.index] = number;
                    this.index++;
                }
            }
            else
            {
                throw new InvalidOperationException("Too many elements!");
            }
        }

        public void Add(int element)
        {
            if (this.index >= ARR_LENGHT)
            {
                throw new InvalidOperationException("Array is full!");
            }
            else
            {
                this.arrDatabase[this.index] = element;
                this.index++;
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
                this.arrDatabase[index] = default(int);
            }
        }

        public int[] Fetch()
        {
            int[] newArr  = new int[this.index];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = this.arrDatabase[i];
            }

            return newArr;
        }
    }
}
