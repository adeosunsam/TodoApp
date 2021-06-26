using System;
using System.Collections.Generic;
using System.Text;

namespace TODOAPP
{
    public class TodoApp
    {
        List<TodoItem> StoringTodoItem = new List<TodoItem>();

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
            foreach (var item in StoringTodoItem)
            {
                Console.WriteLine($"{item.SerialNumber} {item.Item} {(item.IsDone ? "Done" : "Undone")}");
            }
        }
        public void MarkDone(int Num)
        {
            TodoItem newTodo = StoringTodoItem.Find(i => i.SerialNumber == Num);
            if (newTodo == null) Console.WriteLine("SerialNumber not Found");
            newTodo.IsDone = true;
        }

        public void RemoveItem(int ById)
        {
            TodoItem foundItem = StoringTodoItem.Find(i => i.SerialNumber == ById);
            if (foundItem == null) Console.WriteLine("Serial Not Found");
            Console.WriteLine (StoringTodoItem.Remove(foundItem));
        }
    }
}
