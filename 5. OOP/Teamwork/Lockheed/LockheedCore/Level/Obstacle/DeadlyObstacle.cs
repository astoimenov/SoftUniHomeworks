namespace LockHeedCore.Level.Obstacle
{
    using SFML.Graphics;
    using Sprites;

    public class DeadlyObstacle : Obstacle
    {
        public DeadlyObstacle(float x, float y)
            : base(new SpriteSheet(new Sprite(new Texture("level/obstacle/hole.png"))), x, y)
        {
        }
    }
}