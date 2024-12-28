using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolGame
{
    public class RendererByConsole
    {


        char[,] World;
        public readonly int worldHeight, worldWidth;
        int CameraHeight;
        int CameraWidth;



        public RendererByConsole(
            char[,] _world,
            int _worldHeight, 
            int _worldWidth,
            int _camraHeigth, 
            int _camraWidth
        ) 
        {
            World = _world;
            worldHeight = _worldHeight;
            worldWidth = _worldWidth;
            CameraHeight = _camraHeigth;
            CameraWidth = _camraWidth;
        }

        public void RendererWorld()
        {
            for (int i = 0; i < worldHeight; i++) 
            {
                for (int j = 0; j < worldWidth; j++) 
                {
                    Console.SetCursorPosition(j, i); // Primero columna (x), luego fila (y)
                    Console.Write(World[i, j]); // Imprime sin salto de línea     
                }
            }
        }

        public void RendererCamera()
        {
            
        }
    }
}
