namespace LockHeedCore.Character
{
    using SFML.Graphics;
    using Sprites;

    public class Mage : Character
    {
        private static readonly Stats.Stats InitialMageStats = new Stats.Stats(10, 100, 19, 100, 11);
        private static readonly SpriteSheet MageSpriteSheet = new SpriteSheet(
            new Sprite(new Texture("character/mage/mageFront.png")),
            new Sprite(new Texture("character/mage/mageFront.png")),
            new Sprite(new Texture("character/mage/mageBack.png")),
            new Sprite(new Texture("character/mage/mageLeft.png")),
            new Sprite(new Texture("character/mage/mageRight.png")));

        public Mage(string id)
            : base(id, InitialMageStats, MageSpriteSheet)
        {
        }
    }
}