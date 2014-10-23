namespace LockHeedCore
{
    using SFML.Graphics;
    using SFML.Window;
    using Skill.Effect;

    public static class EntityManager
    {
        public static Level.Level CurrentLevel;
        public static Character.Character Character;
        public static RectangleShape HealthRect = new RectangleShape();
        public static RectangleShape ManaRect = new RectangleShape();

        public static void Update()
        {
            Character.Update();
            Character.Move();
            foreach (var enemy in CurrentLevel.Enemies)
            {
                enemy.Update(Character);
                enemy.Move();
            }

            CurrentLevel.RemoveDead();
            foreach (var projectile in Projectile.Projectiles)
            {
                projectile.Move();
            }

            Projectile.DeleteInactive();
        }

        public static void Draw(RenderTarget window)
        {
            HealthRect.Position = new Vector2f(Character.X, Character.Y - 10);
            HealthRect.Size = new Vector2f(Character.Stats.Health * 0.6f, 5);
            ManaRect.Position = new Vector2f(Character.X, Character.Y - 3);
            ManaRect.Size = new Vector2f(Character.Stats.Mana * 0.6f, 5);
            HealthRect.FillColor = Color.Red;
            ManaRect.FillColor = Color.Blue;
            CurrentLevel.Draw(window);
            Character.Draw(window);

            foreach (var projectile in Projectile.Projectiles)
            {
                projectile.Draw(window);
            }

            window.Draw(HealthRect);
            window.Draw(ManaRect);
        }
    }
}