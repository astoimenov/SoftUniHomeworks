﻿namespace LockHeedCore.Sprites
{
    using SFML.Graphics;

    public class SpriteSheet
    {
        public SpriteSheet(Sprite currentSprite, Sprite frontSprite = null, Sprite backSprite = null, Sprite leftSprite = null, Sprite rightSprite = null)
        {
            this.CurrentSprite = currentSprite;
            this.FrontSprite = frontSprite;
            this.BackSprite = backSprite;
            this.LeftSprite = leftSprite;
            this.RightSprite = rightSprite;
        }

        public Sprite CurrentSprite { get; set; }

        public Sprite FrontSprite { get; set; }

        public Sprite BackSprite { get; set; }

        public Sprite LeftSprite { get; set; }

        public Sprite RightSprite { get; set; }
    }
}