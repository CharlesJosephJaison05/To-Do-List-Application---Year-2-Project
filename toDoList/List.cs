using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoList
{
    public class List //Jake/Charles
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public int Priority { get; set; }
        public DateTime? Deadline { get; set; }

        public string TimeRemaining
        {
            get
            {
                if (!Deadline.HasValue) return "No deadline";

                TimeSpan remaining = Deadline.Value - DateTime.Now;
                return remaining.TotalSeconds > 0
                    ? $"{remaining.Days}d {remaining.Hours}h {remaining.Minutes}m"
                    : "Expired";
            }
        }
        public List(string name,  int priority) 
        {
            Name = name;
            Items = new List<Item>();
            Priority = priority;
        
        }   

        public void addItems(Item item)
        {
            Items.Add(item);
        }

        public void deleteItems(Item item) 
        {
            Items.Remove(item); 
        } 



    }
}
