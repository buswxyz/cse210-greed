using Raylib_cs;
using System.Numerics;

namespace Helloworld{
class Colors{
    protected List<string> colorNames = new List<string>();
    protected List<string> createColorList(List<string> colorNames){
        colorNames.Add("Red");
        colorNames.Add("Orange");
        colorNames.Add("Yellow");
        colorNames.Add("Green");
        colorNames.Add("Blue");
        colorNames.Add("Purple");
        colorNames.Add("White");
        
        return colorNames;
    }
}



class FallingObject: Color{
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

    public Gem(Color color, int size): base(color) {
        Size = size;
    }
    // Add a random to make the color chosen random
    override public void Draw() {
        Raylib.DrawRectangle((int)Position.X, (int)Position.Y, Size, Size, Color[0]);
    }
}

class Rock: FallingObject{
    public int Radius { get; set; }

    public Rock(Color color, int radius): base(color) {
        Radius = radius;
    }
     // Add a random to make the color chosen random
    override public void Draw() {
        Raylib.DrawCircle((int)Position.X, (int)Position.Y, Radius, Color[1]);
    }

}

class Player{

}

class CheckCollision{

}

class Score{

}
}
