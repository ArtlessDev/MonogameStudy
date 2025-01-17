using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TrialGame
{
    internal class BaseRoom
    {
        string roomName;
        Texture2D texture;
        List<StagnantUnit> stagnants;
        Rectangle roomRectangle;

        public  BaseRoom()
        {
            RoomName = "defaultName";

            stagnants = new List<StagnantUnit>();
            roomRectangle = new Rectangle(0, 0, 640, 480);
        }

        public List<StagnantUnit> GetRoomColliders()
        {
            stagnants.Add(new StagnantUnit(new Point(0, 0)));
            stagnants.Add(new StagnantUnit(new Point(32, 0)));
            stagnants.Add(new StagnantUnit(new Point(0, 32)));
            stagnants.Add(new StagnantUnit(new Point(64, 0)));
            stagnants.Add(new StagnantUnit(new Point(0, 64)));
            stagnants.Add(new StagnantUnit(new Point(96, 0)));
            stagnants.Add(new StagnantUnit(new Point(0, 96)));
            stagnants.Add(new StagnantUnit(new Point(0, 128)));
            stagnants.Add(new StagnantUnit(new Point(0, 160)));
            
            return stagnants;
        }

        public Texture2D RoomTexture
        {
            get { return texture; }
            set { texture = value; }
        }
        public string RoomName
        {
            get { return roomName; }
            set { roomName = value; }
        }
        public Rectangle RoomRectangle
        {
            get { return roomRectangle; }
            set { roomRectangle = value; }
        }

        public List<StagnantUnit> DefaultColliders
        {
            get { return stagnants; }
            set {  stagnants = value; }
        }
    }
}
