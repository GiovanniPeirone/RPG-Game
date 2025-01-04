using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolGame
{
    public class Game
    {
        public void game()
        {
            int worldHeight = 100;
            int worldWidth = 100;
            int CameraHeight = 40;
            int CameraWidth = 80;
            int CameraPosX = 0;
            int CameraPosY = 0;

            World world = new World(worldHeight, worldWidth);
            var generatedWorld = world.generateWorld();

            RendererByConsole Renderer = new RendererByConsole(
                generatedWorld,
                worldHeight,
                worldWidth,
                CameraWidth,
                CameraHeight,
                CameraPosX,
                CameraPosY
            );

            while (true)
            {
                Renderer.RendererCamera();

                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("¡Saliendo del programa!");
                    break;
                }

                if (key.Key == ConsoleKey.D) CameraPosX++;
                if (key.Key == ConsoleKey.A) CameraPosX--;
                if (key.Key == ConsoleKey.S) CameraPosY++;
                if (key.Key == ConsoleKey.W) CameraPosY--;

                CameraPosX = Math.Clamp(CameraPosX, 0, worldWidth - CameraWidth);
                CameraPosY = Math.Clamp(CameraPosY, 0, worldHeight - CameraHeight);

                Renderer.UpdateCameraPosition(CameraPosX, CameraPosY);

                Console.Clear();
            }
        }
    }
}
