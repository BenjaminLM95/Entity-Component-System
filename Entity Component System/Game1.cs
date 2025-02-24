using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Security.Cryptography.X509Certificates;

namespace Entity_Component_System
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public Texture2D _texture2D;
        public GameObject player;
        public Component playerSprite;       
        public Component playerPosition;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _texture2D = new Texture2D(GraphicsDevice, 1, 1);
            player = new GameObject();
            playerSprite = new Sprite(_texture2D);
            playerPosition = new Movement(new Vector2(50, 50));           
            _texture2D = Content.Load<Texture2D>("Blowfish"); 
            player.AddComponent(playerSprite);
            player.AddComponent(playerPosition);
            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            //_spriteBatch.Draw(player.GetComponent<Sprite>().spriteTexture, player.GetComponent<Movement>().Position, Color.White);
            _spriteBatch.Draw(_texture2D, new Vector2(50, 50), Color.White);

            _spriteBatch.End();

            

            base.Draw(gameTime);
        }
    }
}
