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
        int CameraPosX;
        int CameraPosY;


        public RendererByConsole(
            char[,] _world,
            int _worldHeight,
            int _worldWidth,
            int _camraHeigth,
            int _camraWidth,
            int _cameraPosX,
            int _cameraPosY
            
        ) 
        {
            World = _world;
            worldHeight = _worldHeight;
            worldWidth = _worldWidth;
            CameraHeight = _camraHeigth;
            CameraWidth = _camraWidth;
            CameraPosX = _cameraPosX;
            CameraPosY = _cameraPosY;
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
            for (int i = 0; i < CameraHeight; i++)
            {   
                for (int j = 0; j < CameraWidth; j++)
                {
                    Console.SetCursorPosition(i, j);
                    
                    Console.WriteLine(World[CameraPosY + j, CameraPosX + i ]);
                }
            }   
        }

        public void UpdateCameraPosition(int newX, int newY)
        {
            CameraPosX = newX;
            CameraPosY = newY;
        }

    }
}
