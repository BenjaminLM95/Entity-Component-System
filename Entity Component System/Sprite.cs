using Entity_Component_System;
using Microsoft.Xna.Framework;
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
    public Rectangle spriteRectangle; 
    

    public Sprite(Texture2D aTexture) 
    {
        spriteTexture = aTexture;
    }  

    public void GettingTexture(string name)
    {
        //spriteTexture = Content.Load<Texture2D>(name);
    }   
        
    public Texture2D GettingTexture() {  return spriteTexture; }    
   
    public void SetTexture(Texture2D aTexture) 
    {
        spriteTexture = aTexture;
    }

}

