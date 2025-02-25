using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


public class Sprite : Component
{
    public Texture2D spriteTexture;
    public string spriteName;
    public Rectangle spriteRectangle; 
    

    public Sprite(Texture2D aTexture) 
    {
        spriteTexture = aTexture;
    }  
       
        
    public Texture2D GettingTexture() {  return spriteTexture; }    
   
    public void SetTexture(Texture2D aTexture) 
    {
        spriteTexture = aTexture;
    }

}

