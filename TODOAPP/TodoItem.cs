using System;
using System.Collections.Generic;
using System.Text;

namespace TODOAPP
{
    public class TodoItem
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public bool IsDone { get; set; } = false;

        public TodoItem(int SerialNumber, string Item)
        {
            this.SerialNumber = SerialNumber;
            this.Item = Item;
        }
    }
}
