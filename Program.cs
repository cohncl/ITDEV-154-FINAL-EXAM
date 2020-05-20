using System;

namespace PowerList
{
    class Program
    {
        static void Main(string[] args)
        {
            int key, choice;
            String priority, task, finishBy;
            Console.Write("Enter initial list size : ");
            int size = Convert.ToInt32(Console.ReadLine());

            HashTable table = new HashTable(size);

            while (true) 
            {
                Console.WriteLine("1. Insert or add a record");
                Console.WriteLine("2. Search a record by Key");
                Console.WriteLine("3. Delete a record");
                Console.WriteLine("4. Display whole table");
                Console.WriteLine("5. Search a record by task");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter action to perform : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 6)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter key : ");
                        key = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter task priority (A,B,C,D) : ");
                        priority = Console.ReadLine();
                        Console.Write("Enter a task to do : ");
                        task = Console.ReadLine();
                        Console.Write("Enter a weekday to finish by : ");
                        finishBy = Console.ReadLine();

                        Details aRecord = new Details(key, priority, task, finishBy);

                        table.Insert(aRecord);
                        break;
                    case 2:
                        Console.Write("Enter a key to be searched : ");
                        key = Convert.ToInt32(Console.ReadLine());
                        aRecord = table.Search(key);

                        if (aRecord == null)
                            Console.WriteLine("Key not found\n");
                        else
                            Console.WriteLine(aRecord.toString());

                        break;
                    case 3:
                        Console.Write("Enter a key to be deleted : ");
                        key = Convert.ToInt32(Console.ReadLine());
                        table.Delete(key);
                        break;
                    case 4:
                        table.DisplayTable();
                        break;
                    case 5:
                        Console.Write("Enter a task to be searched : ");
                        task = Console.ReadLine();
                        aRecord = table.Search1(task);

                        if (aRecord == null)
                            Console.WriteLine("Task not found\n");
                        else
                            Console.WriteLine(aRecord.toString());

                        break;
                }
            }
        }
    }
}
