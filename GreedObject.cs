using Raylib_cs;
using System.Numerics;

namespace Helloworld{
class Colors{

    protected List<Color> colorNames = new List<Color>();

    public Colors(){
        colorNames.Add(Color.RED);
        colorNames.Add(Color.ORANGE);
        colorNames.Add(Color.YELLOW);
        colorNames.Add(Color.GREEN);
        colorNames.Add(Color.BLUE);
        colorNames.Add(Color.PURPLE);
        colorNames.Add(Color.WHITE);
    }
    public Color randomColor(){
        Random random = new Random();
        int index = random.Next(0,6);
        Color color = colorNames[index];
        return color;

    }
}
class ColoredObject: Colors  {
    public Color Color { get; set; }

    public ColoredObject (){
        Color = this.randomColor();
    }

}



class FallingObject: ColoredObject{

    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);


    virtual public void Draw(){

    }
    public void Move() {
        Vector2 NewPosition = this.Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        this.Position = NewPosition;
    }
    }

class Gem: FallingObject{

    public int Size {get; set;} 

    public Gem(int size){
        Size = size;
    }
    

    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color);
    }
}

class Rock: FallingObject{
    public int Radius { get; set; }

    public Rock( int radius){
        Radius = radius;
    }
    override public void Draw() {
        Raylib.DrawCircle((int)Position.X, (int)Position.Y, Radius, Color);
    }

}

class Player{

           // public static void Main()
        //{

           // var BallPosition = new Vector2(400, 780);
           // var BallMovementSpeed = 4;
            

            //while (!Raylib.WindowShouldClose())
           // {

               // if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
               //     BallPosition.X += BallMovementSpeed;
               // }

                //if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                //    BallPosition.X -= BallMovementSpeed;
                //}

                //if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                //    BallPosition.Y -= BallMovementSpeed;
                //}

                //if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
               //     BallPosition.Y  += BallMovementSpeed;
               // }

                //Raylib.DrawRectangle(400, 780, 20, 20, Color.MAROON);
            //}   
        //}
}
class CheckCollision{

}

class Score{

}
}
