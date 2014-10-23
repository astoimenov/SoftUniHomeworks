namespace LockHeedCore.Interface
{
    using SFML.Graphics;
    using Sprites;

    public interface IDrawable
    {
        SpriteSheet SpriteSheet { get; set; }

        void Draw(RenderTarget window);
    }
}