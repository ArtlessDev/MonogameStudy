using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialGame
{
    internal class StagnantUnit
    {
        Texture2D unitTexture;
        Rectangle unitRect;
        bool isProjectile;
        double actionEndTime;

        public StagnantUnit()
        {
            unitTexture = null;
            unitRect = new Rectangle(128, 128, 32, 32);
            isProjectile = false;
        }
        public StagnantUnit(Point position)
        {
            unitTexture = null;
            Point unitSize = new Point(32, 32);
            unitRect = new Rectangle(position, unitSize);
            isProjectile = false;
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

        public bool IsProjectile
        {
            get { return isProjectile; }
            set { isProjectile = value; }
        }
        public Rectangle MoveProjectile(GameTime gameTime)
        {
            TimeSpan actionStartTime = gameTime.ElapsedGameTime;

            //DateTime time = DateTime.Now + TimeSpan.FromSeconds(2);
            actionEndTime = gameTime.ElapsedGameTime.TotalMilliseconds + 500.0;

            Debug.WriteLine("shooting!");


            Rectangle changeRect = new Rectangle(UnitRect.X - 5, UnitRect.Y, 32, 32);
            
            return changeRect;

        }
    }
}
