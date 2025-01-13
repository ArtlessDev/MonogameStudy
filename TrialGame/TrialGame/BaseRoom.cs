using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialGame
{
    internal class BaseRoom
    {
        string roomName;
        Texture2D texture;

        BaseRoom()
        {
            RoomName = "defaultName";
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
    }
}
