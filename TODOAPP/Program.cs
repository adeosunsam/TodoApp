using System;

namespace TODOAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoApp ImportTodoClass = new TodoApp();
            Console.Write("Enter 1 to start and anynumber to exit:  ");
            int Start = int.Parse(Console.ReadLine());
            while (Start == 1)
            {
                Console.WriteLine();
                Console.Write("Do you wish to Continue [y/n]: ");
                string y = Console.ReadLine();
                if (y == "y" || y == "Y")
                {
                    Console.Clear();
                    Console.WriteLine("1 to Add item");
                    Console.WriteLine("2 to Remove Item");
                    Console.WriteLine("3 to Mark as Done");
                    Console.WriteLine("4 to print all todo List");
                    Console.WriteLine("5 to exit");
                    Console.Write(">>> ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (num == 1)
                    {
                        Console.Write("Enter Todo item to Add: ");
                        string todoitem = Console.ReadLine();
                        ImportTodoClass.AddItem(todoitem);
                    }
                    else if (num == 2)
                    {
                        Console.Write("Enter SerialNumber to delete: ");
                        int delete = int.Parse(Console.ReadLine());
                        ImportTodoClass.RemoveItem(delete);
                        ImportTodoClass.PrintItem();
                    }
                    else if (num == 3)
                    {
                        Console.Write("Enter SerialNumber to Mark: ");
                        int mark = int.Parse(Console.ReadLine());
                        ImportTodoClass.MarkDone(mark);
                        ImportTodoClass.PrintItem();
                    }
                    else if (num == 4)
                    {
                        Console.Clear();
                        ImportTodoClass.PrintItem();
                    }
                    else
                        break;
                }
                else if (y == "n" || y == "N") break;
                continue;
            }
        }
    }   
}
