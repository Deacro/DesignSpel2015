﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace DesignSpel2015
{
    class Punch
    {
        Vector2 pos;
        Texture2D texture;
        public int timer = 5;
        public Rectangle pR;
        public Punch(Vector2 pos, Texture2D texture)
        {
            this.pos = pos;
            this.texture = texture;
            pR = new Rectangle((int)pos.X, (int)pos.Y, texture.Width, texture.Height);
        }
        public void Update()
        {
            timer--;   
        }
        public void draw(SpriteBatch sprites)
        {
            sprites.Draw(texture, pos, Color.White);
        }
    }
}
