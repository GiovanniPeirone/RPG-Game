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
            int CameraHeight = 20;
            int CameraWidth = 50;
            int CameraPosX = 0;
            int CameraPosY = 0;

            World world = new World(worldHeight, worldWidth);

            RendererByConsole Renderer = new RendererByConsole(
                world.generateWorld(),
                worldHeight,
                worldWidth,
                CameraWidth,
                CameraHeight,
                CameraPosX,
                CameraPosY
            );

            

            while (true) 
            {
                // Llamar al método Renderer.RendererCamera() antes de esperar la tecla
                Renderer.RendererCamera();

                // Separador para la salida
                Console.WriteLine("----------------------------------------------------");

                // Esperar a que se presione una tecla
                ConsoleKeyInfo key = Console.ReadKey(true); // true evita mostrar la tecla en pantalla

                // Verificar la tecla presionada
                if (key.Key == ConsoleKey.Q) // Salir si se presiona 'Q'
                {
                    Console.WriteLine("¡Saliendo del programa!");
                    break;
                }

                if (key.Key == ConsoleKey.D)
                {
                    CameraPosX++;
                    Renderer = new RendererByConsole(
                        world.generateWorld(),
                        worldHeight,
                        worldWidth,
                        CameraWidth,
                        CameraHeight,
                        CameraPosX,
                        CameraPosY
                    );
                }

                if (key.Key == ConsoleKey.A)
                {
                    CameraPosX--;
                    Renderer = new RendererByConsole(
                        world.generateWorld(),
                        worldHeight,
                        worldWidth,
                        CameraWidth,
                        CameraHeight,
                        CameraPosX,
                        CameraPosY
                    );
                }

                if (key.Key == ConsoleKey.S)
                {
                    CameraPosY++;
                    Renderer = new RendererByConsole(
                        world.generateWorld(),
                        worldHeight,
                        worldWidth,
                        CameraWidth,
                        CameraHeight,
                        CameraPosX,
                        CameraPosY
                    );
                }

                if (key.Key == ConsoleKey.W)
                {
                    CameraPosY--;
                    Renderer = new RendererByConsole(
                        world.generateWorld(),
                        worldHeight,
                        worldWidth,
                        CameraWidth,
                        CameraHeight,
                        CameraPosX,
                        CameraPosY
                    );
                }




                // Volver al inicio de la consola (opcional)
                Console.SetCursorPosition(0, 0);
                Console.Clear();
            }
   
        }
    }
}
