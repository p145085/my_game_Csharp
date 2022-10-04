using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game
{
    internal class ItemSequencer
    {
        private static int id;

        public static int NextId()
        {
            return Id++;
        }
        public static void Reset()
        {
            Id = 0;
        }
        public static int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
