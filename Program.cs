using Raylib_cs;
using System.Numerics;

namespace Helloworld{
static class Program{
 public static void Main()
        {

            var ScreenHeight = 480;
            var ScreenWidth = 800;
            var Objects = new List<FallingObject>();
            var Random = new Random();

            Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                // Add a new random object to the screen every iteration of our game loop
                var whichType = Random.Next(3);

                // Generate a random velocity for this object
                var randomY = Random.Next(1, 4);
                var randomX = Random.Next(1, 4);
                
                //Generating a random x coordinate for each object
                var xposition = Random.Next(20,780);
                
                // I am generating the positions of the falling objects here
                var position = new Vector2(xposition, 460);
            
                switch (whichType) {
                            case 0:
                            //Tempararoly using squares for gem, need to switch to actual drawing
                                Console.WriteLine("Creating a gem");
                                var gem = new Gem(Colors[1], 50);
                                gem.Position = position;
                                gem.Velocity = new Vector2(randomX, randomY);
                                Objects.Add(square);
                                break;
                        case 1:
                        //Tempararoly using circles for rock, need to switch to actual drawing
                            Console.WriteLine("Creating a rock");
                            var rock = new Rock(Colors[2], 25);
                            rock.Position = position;
                            rock.Velocity = new Vector2(randomX, randomY);
                            Objects.Add(rock);
                            break;
                        default:
                            break;
                        
                        }
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Colors[6]);

                    // Draw all of the objects in their current location
                    foreach (var obj in Objects) {
                        obj.Draw();
                    }

                    

                    Raylib.EndDrawing();

                    // Move all of the objects to their next location
                    foreach (var obj in Objects) {
                        obj.Move();
                    }
            }

            Raylib.CloseWindow();
        }
            
}  
} 
