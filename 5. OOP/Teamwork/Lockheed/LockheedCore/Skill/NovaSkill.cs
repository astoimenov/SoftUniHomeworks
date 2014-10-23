namespace LockHeedCore.Skill
{
    public class NovaSkill : Skill
    {
        public NovaSkill(string name, int reqStr, int reqAgi, int reqInt, Tier tier, int manaCost, int speed)
            : base(name, reqStr, reqAgi, reqInt, tier, manaCost)
        {
            this.Speed = speed;
        }

        public int Speed { get; private set; }

        public override void Cast(Character.Character character, float mouseX, float mouseY)
        {
            if (character.Stats.Mana >= this.ManaCost)
            {
                character.DecreaseMana(this.ManaCost);
            }
        }
    }
}