using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace TrialGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        PlayerController playerController;
        StagnantUnit enemyController;
        Texture2D _texture;
        BaseRoom currentRoom;
        List<StagnantUnit> stagnants;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 640;
            _graphics.PreferredBackBufferHeight = 480;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            stagnants = new();

            _texture = Content.Load<Texture2D>("./sprites/base-room");
            playerController = new PlayerController();
            playerController.UnitTexture = Content.Load<Texture2D>("./sprites/runner");

            currentRoom = new BaseRoom();

            enemyController = new StagnantUnit();
            enemyController.UnitTexture = Content.Load<Texture2D>("./sprites/wall-tile");
            enemyController.UnitRect = new Rectangle(100, 300, 64, 64);
            stagnants.Add(enemyController);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //foreach(var unit in stagnants)
            //{
                playerController.MovePlayer(currentRoom.GetRoomColliders());
            //}
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {

            }


            //if (playerController.UnitRect.Intersects(enemyController.UnitRect))
            //{
            //    Debug.WriteLine("intersection");
            //}
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            //draws map
            _spriteBatch.Draw(_texture, new Vector2(0, 0), Color.White);

            //draws
            _spriteBatch.Draw(playerController.UnitTexture, playerController.UnitRect, Color.White);
            _spriteBatch.Draw(enemyController.UnitTexture, enemyController.UnitRect, Color.Red);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
