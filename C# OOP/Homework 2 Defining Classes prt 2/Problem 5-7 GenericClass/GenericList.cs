
namespace Problem_5_7_GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class GenericList<T>
        where T : IComparable
    {
        private T[] genericArray;
        private int capacity;
        private int itemCount = 0;

        public T[] GenericArray
        {
            get { return this.genericArray; }
            set { this.genericArray = value; }
        }
        public int Capacity
        {
            get { return this.capacity; }
            set
            {
                if (capacity < 0)
                {
                    throw new IndexOutOfRangeException("List cannot contain a negative amount of items!");
                }
                this.capacity = value;
            }
        }
        public GenericList(int capacity = 4)
        {
            this.Capacity = capacity;
            this.GenericArray = new T[capacity];
        }

        public void AddItem(T item)
        {
            itemCount++;
            if (itemCount == this.Capacity + 1)
            {
                AutoGrow();
            }
            for (int i = 0; i < this.Capacity; i++)
            {
                if (genericArray[i].CompareTo(default(T)) != 0)
                {
                    continue;
                }
                else
                {
                    genericArray[i] = item;
                    break;
                }
            }
        }
        public T this[int index]
        {
            get { return genericArray[index]; }
            set
            {
                if (index < 0 || index > this.capacity - 1)
                {
                    throw new ArgumentOutOfRangeException("Index is outside the boundaries of the array");
                }
                this.genericArray[index] = value;
            }
        }
        public void RemoveItem(int index)
        {
            if (index < 0 || index > this.capacity - 1)
            {
                throw new ArgumentOutOfRangeException("Index is outside the boundaries of the array");
            }
            genericArray[index] = default(T);//This is like string.Empty or null
        }

        public void InsertItem(int index, T item)
        {
            itemCount++;
            if (itemCount == this.Capacity + 1)
            {
                AutoGrow();
            }
            var newArray = new T[this.capacity];
            for (int i = 0; i < index; i++)//Adds the items before the selected index in the new array
            {
                newArray[i] = genericArray[i];
            }
            Array.Copy(genericArray,index,newArray,index+1,this.capacity - index - 1);//Fastest way to shift elemets in an array(by 1 index to the right)
            genericArray = newArray;
            genericArray[index] = item;//Adds the item in the specifyed index
        }
        public void ClearArray()
        {
            for (int i = 0; i < this.capacity; i++)
            {
                genericArray[i] = default(T);
            }
        }
        public int FindItemAtIndex(T item)
        {
            int index = -1;
            for (int i = 0; i < this.capacity; i++)
            {
                if (genericArray[i].CompareTo(item) == 0)//Returns 0 when theres is a match
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public override string ToString()
        {
            StringBuilder arrayContent = new StringBuilder();
            for (int i = 0; i < this.capacity; i++)
            {
                arrayContent.AppendLine("array[" + i + "]" + " = " + genericArray[i]);
            }
            return arrayContent.ToString();
        }
        //Problam 6
        private void AutoGrow()
        {
            this.Capacity = this.capacity * 2;
            var newArray = new T[this.capacity];
            Array.Copy(genericArray, 0, newArray, 0, this.capacity / 2);
            genericArray = new T[this.capacity];
            Array.Copy(newArray, 0, genericArray, 0, this.capacity);
        }
        //Problem 7
        public T Min()
        {
            T minValue = genericArray[0];
            for (int i = 1; i < this.capacity; i++)
            {
                if (minValue.CompareTo(genericArray[i]) == 1)//Returns 1 when the first is greater then the second
                {
                    minValue = genericArray[i];
                }
            }
            return minValue;
        }
        public T Max()
        {
            T maxValue = genericArray[0];
            for (int i = 0; i < this.capacity; i++)
            {
                if (maxValue.CompareTo(genericArray[i]) == -1)//Returns -1 when the second is greater then the first
                {
                    maxValue = genericArray[i];
                }
            }
            return maxValue;
        }
    }
}
