using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_game
{
    public class World
    {
        readonly int id;

        int[] x = new int[1024];    // 'Left' and 'Right'.
        int[] y = new int[1024];    // 'Forward' and 'Back'.
        int[] z = new int[64];      // 'Up' and 'Down'.

        World()
        {

        }
    }
    
    public class Map
    {
        readonly int id;

        //int x_player_pos = Player.x;
        //int y_player_pos = Player.y;
        //int z_player_pos = Player.z;

        Map()
        {

        }
    }
}
