namespace LockHeedCore.Level
{
    using System;
    using Interface;
    using SFML.Graphics;
    using SFML.Window;
    using Sprites;

    public class Enemy : IDrawable, IMoveable, ICollidable
    {
        private const float MovementSpeed = 0.1f;
        public int HP = 100;
        private static readonly Random Random = new Random();

        public Enemy()
        {
            this.SpriteSheet = new SpriteSheet(
                new Sprite(new Texture("enemy/skullFront.png")),
                new Sprite(new Texture("enemy/skullFront.png")),
                new Sprite(new Texture("enemy/skullBack.png")),
                new Sprite(new Texture("enemy/skullLeft.png")),
                new Sprite(new Texture("enemy/skullRight.png")));
            this.X = GetRandomX();
            this.Y = GetRandomY();
            this.IsDead = false;
        }

        public bool IsDead { get; set; }

        public float X { get; set; }

        public float Y { get; set; }

        //----------Collidable------------
        public FloatRect BoundingBox { get; set; }

        //----------Drawable-------------
        public SpriteSheet SpriteSheet { get; set; }

        public static int GetRandomX()
        {
            switch (Random.Next(1, 3))
            {
                case 1:
                    return Random.Next(5, 150) * -1;
                case 2:
                    return Random.Next(Program.WIDTH + 5, Program.WIDTH + 150);
                default:
                    return 0;
            }
        }

        public static int GetRandomY()
        {
            return Random.Next(Program.HEIGHT - 150, Program.HEIGHT + 150);
        }

        public void Move()
        {
            this.SpriteSheet.CurrentSprite.Position = new Vector2f(this.X, this.Y);
            this.BoundingBox = new FloatRect(this.X + 2.5f, this.Y, 40, 60);
            this.CheckCollision();
        }

        public void DecreaseHp(int damage)
        {
            this.HP -= damage;
            if (this.HP <= 0)
            {
                this.IsDead = true;
            }
        }

        public void Draw(RenderTarget window)
        {
            window.Draw(this.SpriteSheet.CurrentSprite);
        }

        public void Update(Character.Character character)
        {
            var rad = Math.Atan2(character.SpriteSheet.CurrentSprite.Position.Y - this.Y, character.SpriteSheet.CurrentSprite.Position.X - this.X);
            var deltaX = Math.Cos(rad);
            var deltaY = Math.Sin(rad);

            this.X += (float)deltaX * MovementSpeed;
            this.Y += (float)deltaY * MovementSpeed;

            int deg = (int)(rad * 180 / Math.PI);

            if (deg >= 45 && deg < 135)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.FrontSprite;
            }
            else if (deg >= 135 && deg < 225)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.LeftSprite;
            }
            else if (deg >= 225 && deg < 315)
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.BackSprite;
            }
            else
            {
                this.SpriteSheet.CurrentSprite = this.SpriteSheet.RightSprite;
            }
        }

        public virtual bool CheckCollision()
        {
            if (this.BoundingBox.Intersects(EntityManager.Character.BoundingBox))
            {
                this.IsDead = true;
                EntityManager.Character.DecreaseHP(15);
                return true;
            }

            return false;
        }
    }
}