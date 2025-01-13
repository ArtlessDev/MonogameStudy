using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialGame
{
    internal class StagnantUnit
    {
        Texture2D unitTexture;
        Rectangle unitRect;

        public StagnantUnit()
        {
            unitTexture = null;
            unitRect = new Rectangle(128, 128, 32, 32);
        }
        public StagnantUnit(Point position)
        {
            unitTexture = null;
            unitRect = new Rectangle(position, new Point(32, 32));
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
    }
}
