namespace LockHeedCore.Level
{
    using System;
    using System.Collections.Generic;
    using Door;
    using Interface;
    using Obstacle;
    using SFML.Graphics;
    using Sprites;

    public class Level : IDrawable
    {
        public List<Door.Door> Doors = new List<Door.Door>(2);
        public List<Enemy> Enemies = new List<Enemy>(10);
        private static readonly Random Random = new Random();

        public Level(int id, List<Obstacle.Obstacle> obstacles)
        {
            this.Id = id;
            this.Obstacles = obstacles ?? new List<Obstacle.Obstacle>();
            this.SpriteSheet = new SpriteSheet(new Sprite(new Texture("level/baseLevel.png")));
        }

        public int Id { get; set; }

        public SpriteSheet SpriteSheet { get; set; }

        public List<Obstacle.Obstacle> Obstacles { get; set; }

        public static Level GenerateSingleLevel()
        {
            List<Enemy> enemies = new List<Enemy>();
            for (int enemyNum = 1; enemyNum <= Random.Next(1, 11); enemyNum++)
            {
                enemies.Add(new Enemy());
            }

            List<Obstacle.Obstacle> obstacles = new List<Obstacle.Obstacle>();
            for (int obstNumber = 1; obstNumber <= 4; obstNumber++)
            {
                Obstacle.Obstacle obstacle = null;
                switch (Random.Next(1, 4))
                {
                    case 1:
                        obstacle = new ChestObstacle(obstNumber * 150, Random.Next(80, 350), null);
                        break;
                    case 2:
                        obstacle = new DeadlyObstacle(obstNumber * 150, Random.Next(80, 350));
                        break;
                    case 3:
                        obstacle = new ObstructedObstacle(obstNumber * 150, Random.Next(80, 350));
                        break;
                }

                obstacles.Add(obstacle);
            }

            List<Door.Door> doors = new List<Door.Door>(2);
            DoorPosition randomDoorPosition = Door.Door.GetRandomPosition();
            doors.Add(new Door.Door(randomDoorPosition, 222));
            Level level = new Level(222, obstacles)
            {
                Enemies = enemies,
                Doors = doors
            };
            return level;
        }

        public void CheckDoors()
        {
            if (this.Enemies == null)
            {
                foreach (var door in this.Doors)
                {
                    door.IsOpen = true;
                }
            }
        }

        public void Draw(RenderTarget window)
        {
            window.Draw(this.SpriteSheet.CurrentSprite);
            foreach (var door in this.Doors)
            {
                door.Draw(window);
            }

            foreach (var obstacle in this.Obstacles)
            {
                obstacle.Draw(window);
            }

            foreach (var enemy in this.Enemies)
            {
                enemy.Draw(window);
            }
        }

        public void RemoveDead()
        {
            this.Enemies.RemoveAll(item => item.IsDead);
        }

        public override string ToString()
        {
            return string.Join(", ", this.Doors.ToString());
        }
    }
}