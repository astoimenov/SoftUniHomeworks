namespace LockHeedCore.Character
{
    using SFML.Graphics;
    using Sprites;

    public class Rogue : Character
    {
        private static readonly Stats.Stats InitialRogueStats = new Stats.Stats(17, 100, 12, 100, 12);
        private static readonly SpriteSheet RogueSpriteSheet = new SpriteSheet(
            new Sprite(new Texture("character/rogue/rogueFront.png")),
            new Sprite(new Texture("character/rogue/rogueFront.png")),
            new Sprite(new Texture("character/rogue/rogueBack.png")),
            new Sprite(new Texture("character/rogue/rogueLeft.png")),
            new Sprite(new Texture("character/rogue/rogueRight.png")));

        public Rogue(string id)
            : base(id, InitialRogueStats, RogueSpriteSheet)
        {
        }
    }
}