namespace LockHeedCore.Level.Obstacle
{
    using Interface;
    using SFML.Graphics;
    using SFML.Window;
    using Sprites;

    public abstract class Obstacle : IDrawable, ICollidable
    {
        protected Obstacle(SpriteSheet spriteSheet, float x, float y)
        {
            this.SpriteSheet = spriteSheet;
            this.X = x;
            this.Y = y;
            this.BoundingBox = new FloatRect(this.X + 5, this.Y, 40, 40);
        }

        public SpriteSheet SpriteSheet { get; set; }

        public float X { get; set; }

        public float Y { get; set; }

        public FloatRect BoundingBox { get; set; }

        public virtual void Draw(RenderTarget window)
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.X, this.Y);
            window.Draw(this.SpriteSheet.CurrentSprite);
        }

        public override string ToString()
        {
            return this.GetType() + " " + string.Format("X:{0}, Y{1}", this.X, this.Y);
        }
    }
}
