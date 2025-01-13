using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;

namespace TrialGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        PlayerController playerController;
        PlayerController enemyController;
        Texture2D _texture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            //_texture = Content.Load<Texture2D>("playership");
            playerController = new PlayerController();
            playerController.UnitTexture = Content.Load<Texture2D>("playership");
            
            enemyController = new PlayerController();
            enemyController.UnitTexture = Content.Load<Texture2D>("playership");
            enemyController.UnitRect = new Rectangle(100, 300, 128, 128);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
                
            playerController.MovePlayer();

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {

            }


            if (playerController.UnitRect.Intersects(enemyController.UnitRect))
            {
                Debug.WriteLine("intersection");
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            //_spriteBatch.Draw(_texture, new Rectangle(100, 100, 100, 200), Color.White);
            _spriteBatch.Draw(playerController.UnitTexture, playerController.UnitRect, Color.White);
            _spriteBatch.Draw(enemyController.UnitTexture, enemyController.UnitRect, Color.Red);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
