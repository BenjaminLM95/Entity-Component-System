using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;



 public class Movement : Component
  {

    public Movement(Vector2 initialPosition, Vector2 initialScale) 
    {
        Position = initialPosition; 
        Scale = initialScale;
        Rotation = new Vector2 (0, 0);
    }

    public Vector2 Position { get; set; }

    public Vector2 Rotation { get; set; }

    public Vector2 Scale { get; set; } 


    public void Move(Vector2 movePosition) 
    {
        Position += movePosition;
    }

    public void UpdateInputSystem(GameTime gameTime) 
    {
        KeyboardState keyboardState = Keyboard.GetState();

        if (keyboardState.IsKeyDown(Keys.A))
        {
            Move(new Vector2(-1, 0));
        }
        else if (keyboardState.IsKeyDown(Keys.D))
        {
            Move(new Vector2(1, 0));
        }
        else if (keyboardState.IsKeyDown(Keys.W))
        {
            Move(new Vector2(0, -1));
        }
        else if (keyboardState.IsKeyDown((Keys)Keys.S))
        {
            Move(new Vector2(0, 1));
        }

    }



  }

