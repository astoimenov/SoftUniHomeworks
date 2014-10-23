namespace LockHeedCore.Skill.Interface
{
    using Character;

    public interface ICastable
    {
        void Cast(Character character, float x, float y);
    }
}