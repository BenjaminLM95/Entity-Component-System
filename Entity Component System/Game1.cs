using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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
            playerPosition = new Movement(new Vector2(50, 50), new Vector2(100, 100));           
            _texture2D = Content.Load<Texture2D>("Blowfish");
            playerSprite = new Sprite(_texture2D);
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

            KeyboardState keyboardState = Keyboard.GetState();
                      

            player.GetComponent<Movement>().UpdateInputSystem(gameTime); 

                base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            _spriteBatch.Draw(player.GetComponent<Sprite>().spriteTexture, new Rectangle((int)player.GetComponent<Movement>().Position.X, (int)player.GetComponent<Movement>().Position.Y,
                              (int)player.GetComponent<Movement>().Scale.X,(int)player.GetComponent<Movement>().Scale.X), Color.White);
            

            _spriteBatch.End();

            

            base.Draw(gameTime);
        }
    }
}
