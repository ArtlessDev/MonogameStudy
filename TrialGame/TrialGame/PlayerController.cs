using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Diagnostics;

namespace TrialGame
{
    internal class PlayerController
    {
        Texture2D unitTexture;
        Rectangle unitRect;

        public PlayerController()
        {
            unitTexture = null;
            unitRect = new Rectangle(320, 240, 16, 32);
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

        public void MovePlayer(List<StagnantUnit> collisionGroup)
        {
            int startingX = this.UnitRect.X;
            int startingY = this.UnitRect.Y;
            int xCoord = this.UnitRect.X;
            int yCoord = this.UnitRect.Y;
            int tempX = 0;
            int tempY = 0;

            if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                tempX += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                tempX -= 2;
            }

            xCoord += tempX;
            
            //for the time being, this works but the player is capable of getting 'underneath' object so a better solution is needed in the future
            foreach (var unit in collisionGroup) 
            {
                if (unit.UnitRect.Intersects(this.UnitRect) && tempX <= 0)
                {
                    xCoord = startingX + 2;
                }
                else if (unit.UnitRect.Intersects(this.UnitRect) && tempX >= 0)
                {
                    xCoord = startingX - 2;
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                tempY += 2;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                tempY -= 2;
            }

            yCoord += tempY;

            foreach (var unit in collisionGroup)
            {
                if (unit.UnitRect.Intersects(this.UnitRect) && tempY <= 0)
                {
                    yCoord = startingY + 2;
                }
                else if (unit.UnitRect.Intersects(this.UnitRect) && tempY>=0)
                {
                    yCoord = startingY - 2;
                }
            }

            this.UnitRect = new Rectangle(xCoord, yCoord, 32, 64);

            //playerController.UnitRect.Offset(xCoord+1, yCoord);
            //Debug.WriteLine("X: " + xCoord + ", Y: " + yCoord);
            //Debug.WriteLine("X: " + tempX + ", Y: " + tempY);
            //Debug.WriteLine("X: " + startingX + ", Y: " + startingY);

        }
    }
}
