﻿namespace LockHeedCore.Level.Obstacle
{
    using SFML.Graphics;
    using Sprites;

    public class ObstructedObstacle : Obstacle
    {
        public ObstructedObstacle(float x, float y)
            : base(new SpriteSheet(new Sprite(new Texture("level/obstacle/rock.png"))), x, y)
        {
        }
    }
}