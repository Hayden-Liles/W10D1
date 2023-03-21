using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W10D1.Models
{
    public class Snack
    {
        public Snack(int id, string name, int quantity, bool sugarFree)
        {
            this.id = id;
            this.name = name;
            this.quantity = quantity;
            this.sugarFree = sugarFree;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public bool sugarFree {get; set;}
    }
}