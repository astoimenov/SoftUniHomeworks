namespace LockHeedCore.Level
{
    using System;
    using System.Collections.Generic;
    using Door;
    using Obstacle;

    public class Map
    {
        public Level[,] Levels = new Level[21, 21];
        private static readonly Random Random = new Random();

        public Map(string id)
        {
            this.Id = id;
        }

        public string Id { get; set; }

        public static Map GenerateMap()
        {
            DoorPosition prevLevelDoorPosition = DoorPosition.Bottom;
            Level[,] tempLevels = new Level[21, 21];
            int arrayPosX = 10;
            int arrayPoxY = 10;
            for (int levelNumber = 1; levelNumber <= 10; levelNumber++)
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
                if (levelNumber == 1)
                {
                    doors.Add(new Door.Door(randomDoorPosition, levelNumber + 1));
                    prevLevelDoorPosition = Door.Door.GetOppositePosition(randomDoorPosition);
                }
                else if (levelNumber > 1 && levelNumber < 10)
                {
                    doors.Add(new Door.Door(prevLevelDoorPosition, levelNumber - 1));

                    if (randomDoorPosition == prevLevelDoorPosition)
                    {
                        randomDoorPosition = Door.Door.GetOppositePosition(randomDoorPosition);
                    }

                    doors.Add(new Door.Door(randomDoorPosition, levelNumber + 1));
                    prevLevelDoorPosition = Door.Door.GetOppositePosition(randomDoorPosition);
                }
                else
                {
                    doors.Add(new Door.Door(prevLevelDoorPosition, levelNumber - 1));
                }

                Level level = new Level(levelNumber, obstacles)
                {
                    Doors = doors,
                    Enemies = enemies
                };
                tempLevels[arrayPosX, arrayPoxY] = level;
                switch (randomDoorPosition)
                {
                    case DoorPosition.Top:
                        arrayPoxY--;
                        break;
                    case DoorPosition.Bottom:
                        arrayPoxY++;
                        break;
                    case DoorPosition.Left:
                        arrayPosX--;
                        break;
                    case DoorPosition.Right:
                        arrayPosX++;
                        break;
                }
            }

            Map map = new Map("map1") { Levels = tempLevels };
            return map;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, this.Levels);
        }
    }
}