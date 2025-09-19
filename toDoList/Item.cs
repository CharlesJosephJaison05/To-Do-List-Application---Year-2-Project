using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoList //Jake
{
    public class Item
    {
        public string Description {get; set;}
        public bool IsCompleted { get; set; } 

        public Item(string description) 
        {
            Description = description;
            IsCompleted = false;
        }
        


    }
}
