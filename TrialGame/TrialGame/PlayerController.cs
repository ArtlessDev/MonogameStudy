using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialGame
{
    internal class PlayerController
    {
        Texture2D unitTexture;
        Rectangle unitRect;

        public PlayerController() 
        { 
            unitTexture = null;
            unitRect = new Rectangle(0, 0, 128, 128);
        }

        public Rectangle UnitRect
        {
            get { return unitRect; }
            set { unitRect = value; }
        }
        public Texture2D UnitTexture
        {
            get { return unitTexture; }
            set { unitTexture = value; }
        }

        public void MovePlayer()
        {

            int xCoord = this.UnitRect.X;
            int yCoord = this.UnitRect.Y;

            if (Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                yCoord += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                xCoord += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                yCoord -= 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                xCoord -= 2;
            }
            this.UnitRect = new Rectangle(xCoord, yCoord, 128, 128);

            //playerController.UnitRect.Offset(xCoord+1, yCoord);
            Debug.WriteLine("X: " + xCoord + ", Y: " + yCoord);

        }
    }
}
