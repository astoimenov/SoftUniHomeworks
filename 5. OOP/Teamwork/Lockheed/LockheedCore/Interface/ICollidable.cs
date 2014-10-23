namespace LockHeedCore.Interface
{
    using SFML.Graphics;

    public interface ICollidable
    {
        FloatRect BoundingBox { get; set; }
    }
}