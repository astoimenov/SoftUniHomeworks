namespace LockHeedCore.Character
{
    using System.Collections.Generic;
    using System.Linq;
    using Interface;
    using SFML.Graphics;
    using SFML.Window;
    using Skill;
    using Sprites;

    public abstract class Character : ICollidable, IMoveable, IDrawable
    {
        protected Character(string id, Stats.Stats stats, SpriteSheet spriteSheet)
        {
            this.Id = id;
            this.Stats = stats;
            this.SpriteSheet = spriteSheet;
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.X, this.Y);
            this.BoundingBox = new FloatRect(this.X, this.Y + 50, 30, 30);
            this.X = 100;
            this.Y = 100;
            this.IsDead = false;
        }

        public Stats.Stats Stats { get; set; }

        public string Id { get; set; }

        //----------Moveable--------------
        public float X { get; set; }

        public float Y { get; set; }

        //----------Collidable------------
        public FloatRect BoundingBox { get; set; }

        //----------Drawable-------------
        public SpriteSheet SpriteSheet { get; set; }

        public List<Skill> UnlockedSkills { get; set; }

        public List<Tier> UnlockedTiers { get; set; }

        public Skill CurrentSkill { get; set; }

        public bool IsDead { get; set; }

        public void Update()
        {
            if (Events.KeyArrowDown)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.FrontSprite;
                if (this.BoundingBox.Top <= Program.HEIGHT - 85)
                {
                    FloatRect rect = new FloatRect(
                        this.X + 10,
                        this.Y + 60 + Program.MovementModifier,
                        this.BoundingBox.Width,
                        this.BoundingBox.Height);
                    if (!this.CheckCollision(rect))
                    {
                        this.Y += Program.MovementModifier;
                    }
                }
            }

            if (Events.KeyArrowUp)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.BackSprite;
                if (this.BoundingBox.Top >= 55)
                {
                    FloatRect rect = new FloatRect(
                        this.X + 10,
                        this.Y + 60 - Program.MovementModifier,
                        this.BoundingBox.Width,
                        this.BoundingBox.Height);
                    if (!this.CheckCollision(rect))
                    {
                        this.Y -= Program.MovementModifier;
                    }
                }
            }

            if (Events.KeyArrowLeft)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.LeftSprite;
                if (this.BoundingBox.Left >= 55)
                {
                    FloatRect rect = new FloatRect(
                        this.X - Program.MovementModifier + 10,
                        this.Y + 60, 
                        this.BoundingBox.Width,
                        this.BoundingBox.Height);
                    if (!this.CheckCollision(rect))
                    {
                        this.X -= Program.MovementModifier;
                    }
                }
            }

            if (Events.KeyArrowRight)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.RightSprite;

                if (this.BoundingBox.Left <= Program.WIDTH - 100)
                {
                    FloatRect rect = new FloatRect(
                        this.X + 10 + Program.MovementModifier, 
                        this.Y + 60, 
                        this.BoundingBox.Width, 
                        this.BoundingBox.Height);
                    if (!this.CheckCollision(rect))
                    {
                        this.X += Program.MovementModifier;
                    }
                }
            }
        }

        public void Move()
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.X, this.Y);
            this.BoundingBox = new FloatRect(this.X + 10, this.Y + 60, 40, 40);
        }

        public void Draw(RenderTarget window)
        {
            window.Draw(this.SpriteSheet.CurrentSprite);
        }
        
        public bool CheckCollision(FloatRect tempRect)
        {
            return EntityManager.CurrentLevel.Obstacles.Any(
                obstacle => obstacle.BoundingBox.Intersects(tempRect));
        }
        
        public void DecreaseMana(int value)
        {
            this.Stats = new Stats.Stats(this.Stats.Agility, this.Stats.Health, this.Stats.Intelect, this.Stats.Mana - value, this.Stats.Strength);
        }

        public void DecreaseHP(int value)
        {
            this.Stats = new Stats.Stats(this.Stats.Agility, this.Stats.Health - value, this.Stats.Intelect, this.Stats.Mana, this.Stats.Strength);
        }
    }
}