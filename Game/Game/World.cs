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


        public int roomposY, roomposX = 0;

        public char[,] Room_01 = {
            {'.',',','.','.','.','.'},
            {'.','#','#','#','#','.'},
            {'.','#','.','.','#','.'},
            {'.','#','.','.','>','.'},
            {'.','#','.','.','#','.'},
            {'.','#','#','#','#','.'},
            {'.',',','.','.','.','.'},
        };



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
                    if (j % 2 == 0 && WorldArray[i, j] != ' ')
                    {
                        WorldArray[i, j] = ',';
                    }
                }

                if (i == 1)
                {
                    for(int k = 0; k < worldWidth; k++)
                    {
                        WorldArray[i, k] = Room_01[roomposY + i, roomposX + k];
                    }
                }


            }
            WorldArray[5, 5] = 'M';

            return WorldArray;
        }


        
    }
}
