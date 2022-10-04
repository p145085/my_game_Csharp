using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game
{
    public class Item
    {
        public int id;
        public string name;
        public Item()
        {

        }
        public int Id { 
            get
            {
                return id;
            } 
            set
            {
                this.id = ItemSequencer.NextId();
            }
        }
        public string Name { get; set; }
    }
}
