using System;

namespace TODOAPP
{
    class Program
    {

        static void Main(string[] args)
        {
            TodoApp ImportTodoClass = new TodoApp();
            Console.Write("Enter 1 to start and anynumber to exit ");
            int x = int.Parse(Console.ReadLine());
            while (x == 1)
            {
                Console.Write("Enter Todo item to Add: ");
                string todoitem = Console.ReadLine();
                ImportTodoClass.AddItem(todoitem);
                Console.Write("Enter 1 to Another Todo item or Enter any number to Exit: ");
                int y = int.Parse(Console.ReadLine());
                if (y != 1)
                {
                    Console.WriteLine();
                    ImportTodoClass.PrintItem();
                    Console.WriteLine();
                    Console.WriteLine("1 to Add item Again");
                    Console.WriteLine("2 to Remove Item");
                    Console.WriteLine("3 to print all todo item");
                    Console.WriteLine("4 to exit");
                    Console.Write(">>> ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (num == 1)
                    {

                        Console.Write("Enter 1 to Another Todo item or Enter any number to Exit: ");
                        int z = int.Parse(Console.ReadLine());
                        if (z != 1)
                        {
                            break;
                        }
                    }
                    else if (num == 2)
                    {
                        Console.Write("Enter SerialNumber to delete: ");
                        int delete = int.Parse(Console.ReadLine());
                        ImportTodoClass.RemoveItem(delete);
                        ImportTodoClass.PrintItem();
                        break;
                    }
                    else if (num == 3)
                    {
                        ImportTodoClass.PrintItem();
                        break;
                    }
                    else
                        break;
                }
            }
        }
    }
    
}
