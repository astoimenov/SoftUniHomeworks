namespace LockHeedCore.Interface
{
    public interface IMoveable
    {
        float X { get; set; }

        float Y { get; set; }

        void Move();
    }
}