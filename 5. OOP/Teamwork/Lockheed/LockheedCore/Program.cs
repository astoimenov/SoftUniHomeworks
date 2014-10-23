namespace LockHeedCore
{
    using System;
    using Character;
    using SFML.Graphics;
    using SFML.Window;
    using Skill;

    public class Program
    {
        public const int FPS = 60;
        public const float RATIO = 16f / 9f;
        public const int WIDTH = 800;
        public const int HEIGHT = (int)(WIDTH / RATIO);
        public const float MAX_TIMESTEP = 1000f / FPS;

        public const float MovementModifier = 0.5f;

        public static void Main()
        {
            var resolution = new VideoMode(WIDTH, HEIGHT, 32);
            var windowSettings = new ContextSettings(32, 0, 4);
            var window = new RenderWindow(resolution, "Lockheed the Game", Styles.Close, windowSettings);

            window.Closed += Events.OnClose;
            window.KeyPressed += Events.OnKeyPressed;
            window.KeyReleased += Events.OnKeyReleased;
            window.MouseButtonPressed += Events.OnMouseButtonPressed;
            window.SetActive();

            Level.Level newLevel = Level.Level.GenerateSingleLevel();
            Character.Character glava = new Rogue("glava");

            glava.CurrentSkill = new ProjectileSkill(
                "fireball", 10, 10, 10, Tier.Beginner, 5, "weapons/projectiles/fireBall.png", 5);
            
            EntityManager.CurrentLevel = newLevel;
            EntityManager.Character = glava;

            DateTime lastTick = DateTime.Now;
            while (window.IsOpen())
            {
                float dt = (float)(DateTime.Now - lastTick).TotalMilliseconds;
                lastTick = DateTime.Now;
                window.DispatchEvents();

                while (dt > 0)
                {
                    EntityManager.Update();
                    dt -= MAX_TIMESTEP;
                }

                window.Clear(Color.Black);
                EntityManager.Draw(window);
                window.Display();
            }
        }
    }
}