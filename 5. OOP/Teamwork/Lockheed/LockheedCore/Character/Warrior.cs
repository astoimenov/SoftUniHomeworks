namespace LockHeedCore.Character
{
    using SFML.Graphics;
    using Sprites;

    public class Warrior : Character
    {
        private static readonly Stats.Stats InitialWarriorStats = new Stats.Stats(10, 100, 10, 100, 18);
        private static readonly SpriteSheet WarriorSpriteSheet = new SpriteSheet(
            new Sprite(new Texture("character/warrior/warriorFront.png")),
            new Sprite(new Texture("character/warrior/warriorFront.png")),
            new Sprite(new Texture("character/warrior/warriorBack.png")),
            new Sprite(new Texture("character/warrior/warriorLeft.png")),
            new Sprite(new Texture("character/warrior/warriorRight.png")));

        public Warrior(string id)
            : base(id, InitialWarriorStats, WarriorSpriteSheet)
        {
        }
    }
}