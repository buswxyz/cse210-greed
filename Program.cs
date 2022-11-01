using Raylib_cs;

class Color{
    protected List<string> colorNames = new List<string>();
    protected List<string> createColorList(List<string> colorNames){
        colorNames.Add("Red");
        colorNames.Add("Orange");
        colorNames.Add("Yellow");
        colorNames.Add("Green");
        colorNames.Add("Blue");
        colorNames.Add("Purple");
        return colorNames;
    }
}

class Location: Color{
    Random random = new Random();
    protected int y = 400;
    protected int getRandomX(){
        int x = random.Next(20, 780);
        return x;
    }

}

class FallingObject: Location{
    Random random = new Random();
    protected int movementSpeed = random.Next(1, 8);
    protected void fallingSpeed(){

    }
}

class Rock: FallingObject{

}

class Gem: FallingObject{

}

class Player{

}

class CheckCollision{

}

class Score{

}

class Window{
    public void createWindow(){
        var windowHeight = 480;
        var windowWidth = 800;
        Raylib.InitWindow(windowWidth, windowHeight, "Greed");
        Raylib.SetTargetFPS(60);
    }
}