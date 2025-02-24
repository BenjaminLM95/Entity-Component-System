using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 public class Movement
  {
    public Vector2 Position { get; set; }

    public Vector2 Rotation { get; set; }

    public Vector2 Scale { get; set; } 


    public void Move(Vector2 movePosition) 
    {
        Position += movePosition;
    }


  }

