namespace LockHeedCore.Skill.Effect
{
    using LockHeedCore.Interface;
    using SFML.Graphics;
    using Sprites;

    public abstract class Effect : ICollidable, IMoveable, IDrawable
    {
        public string Directory;

        protected Effect(SpriteSheet spriteSheet, float x, float y)
        {
            this.SpriteSheet = spriteSheet;
            this.X = x;
            this.Y = y;
        }

        public float X { get; set; }

        public float Y { get; set; }

        public FloatRect BoundingBox { get; set; }

        public SpriteSheet SpriteSheet { get; set; }

        public abstract void Move();

        public virtual void Draw(RenderTarget window)
        {
            window.Draw(this.SpriteSheet.CurrentSprite);
        }
    }
}
