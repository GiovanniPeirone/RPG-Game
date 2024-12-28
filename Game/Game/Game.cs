using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolGame
{
    public class Game
    {
        public void game()
        {


            int worldHeight = 30;
            int worldWidth = 100; 
            int CameraHeight = 100;
            int CameraWidth = 100;


        World world = new World(300, 300);

            RendererByConsole Renderer = new RendererByConsole(
                world.generateWorld(),
                worldHeight,
                worldWidth,
                CameraHeight,
                CameraWidth
            );


            while (true) 
            {
                Console.SetCursorPosition(0, 0);

                Renderer.RendererCamera();
                
                //Console.WriteLine("----------------------------------------------------");

                Renderer.RendererWorld();

                Console.Clear();
            }
            
        }
    }
}
