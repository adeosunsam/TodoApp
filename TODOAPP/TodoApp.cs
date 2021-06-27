using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TODOAPP
{
    public class TodoApp
    {
        List<TodoItem> StoringTodoItem = new List<TodoItem> ();

        int SerialNumber = 1;
        public TodoItem AddItem(string TodoItem)
        {
            
            TodoItem TodoImport = new TodoItem(SerialNumber, TodoItem);
            StoringTodoItem.Add(TodoImport);
            SerialNumber++;
            return TodoImport;
        }
        
        public void PrintItem()
        {
            TabularData.PrintLines();
            TabularData.PrintHeadings("S/N", "TODO ITEM", "STATUS");
            TabularData.PrintLines();

            foreach (var item in StoringTodoItem)
            {
                TabularData.PrintHeadings(item.SerialNumber.ToString(), item.Item, (item.IsDone ? "Done" : "Undone"));
                TabularData.PrintLines();
            }
        }
        public void MarkDone(int Num)
        {
            TodoItem newTodo = StoringTodoItem.Find(i => i.SerialNumber == Num);
            try
            {
                newTodo.IsDone = true;
            }
            catch
            {
                Console.WriteLine("SerialNumber not Found");
            }
        }

        public void RemoveItem(int ById)
        {
            TodoItem foundItem = StoringTodoItem.Find(i => i.SerialNumber == ById);
            if (foundItem == null) Console.WriteLine("Serial Not Found");
            StoringTodoItem.Remove(foundItem);
        }
    }
    
    public static class TabularData
    {
        private const int TableWidth = 80;

        public static void PrintLines()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        public static void PrintHeadings(params string[] col)
        {
            int Width = (TableWidth - col.Length) / col.Length;
            const string seed = "|";
            string row = col.Aggregate(seed, (seperator, colText) => seperator + GetCenterAllignedText(colText, Width) + seed);
            Console.WriteLine(row);

        }

        private static string GetCenterAllignedText(string colText, int width)
        {
            colText = colText.Length > width ? colText.Substring(0, width - 3) + "..." : colText;
            return string.IsNullOrEmpty(colText) ? new string(' ', width)
                : colText.PadRight(width - ((width - colText.Length) / 2)).PadLeft(width); 
        }
    }

}
