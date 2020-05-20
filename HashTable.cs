using System;
using System.Collections.Generic;
using System.Text;

namespace PowerList
{
    class HashTable
    {
        private Details[] array;
        private int m; //size of the array
        int n;         //number of records

        public HashTable() : this(11)
        {
        }

        public HashTable(int tableSize)
        {
            m = tableSize;
            array = new Details[m];
            n = 0;
        }

        int hash(int key) 
        {
            return (key % m);
        }

        public void Insert(Details newRecord)
        {
            int key = newRecord.getkey();
            int h = hash(key);

            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null || array[location].getkey() == -1)
                {
                    array[location] = newRecord;
                    n++;
                    return;
                }

                if (array[location].getkey() == key)
                    throw new System.InvalidOperationException("Duplicate key");

                location = (h + i) % m;
            }
            Console.WriteLine("Table is full : Record can't be inserted ");
        }

        public Details Search(int key)
        {
            int h = hash(key);
            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null)
                {
                    return null;
                }
                if (array[location].getkey() == key)
                    return array[location];
                location = (h + i) % m;
            }
            return null;
        }

        public Details Search1(string task)
        {
            for (int h = 0; h < m; h++)
            {
                    //if (array[h] == null)
                    //{
                    //    return null;
                    //}

                    if (array[h].gettaskName().ToUpper() == task.ToUpper())
                        return array[h];
            }
            return null;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < m; i++)
            {
                Console.Write("[" + i + "]  -->  ");

                if (array[i] != null && array[i].getkey() != -1)
                    Console.WriteLine(array[i].toString());
                else
                    Console.WriteLine("___");
            }
        }

        public Details Delete(int key)
        {
            int h = hash(key);
            int location = h;

            for (int i = 1; i < m; i++)
            {
                if (array[location] == null)
                    return null;
                if (array[location].getkey() == key)
                {
                    Details temp = array[location];
                    array[location].setId(-1);
                    n--;
                    return temp;
                }
                location = (h + i) % m;
            }
            return null;
        }
    }
}
