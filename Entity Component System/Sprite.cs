using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


public class Sprite : Component
{
    public Texture2D spriteTexture;
    public string spriteName;

    public Sprite(Texture2D _texture2D)
    {
        spriteTexture = _texture2D;
    }


    public void GettingTexture(string name)
    {
        //spriteTexture = Game1.Content.Load<Texture2D>(name);
    }   
        


}

