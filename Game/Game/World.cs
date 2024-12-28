using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolGame
{
    public class World
    {

        /* world Array
         ******************************************
         ****************************************** 
         ******************************************
         ******************************************
         ******************************************
         ******************************************
         ******************************************
         ******************************************
         ******************************************
         */

        /* camera Array
         ******************************************
         *|---------|****************************** 
         *|*********|******************************
         *|**cam****|******************************
         *|*********|************world*************
         *|---------|******************************
         ******************************************
         ******************************************
         ******************************************
         */
        public readonly int worldHeight, worldWidth;

        public World(int _worldHeight, int _worldWidth)
        {
            worldHeight = _worldHeight;
            worldWidth = _worldWidth;
        }

        public char[,] generateWorld()
        {
            char[,] WorldArray = new char[worldHeight, worldWidth];

            for (int i = 0; i < worldHeight; i++)
            {
                for (int j = 0; j < worldWidth; j++)
                {
                    WorldArray[i, j] = '*'; // Inicializa cada celda con un asterisco
                }
            }
            return WorldArray;
        }
    }
}
