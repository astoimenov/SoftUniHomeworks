namespace LockHeedCore
{
    using System;
    using SFML.Graphics;
    using SFML.Window;

    public static class Events
    {
        public static bool KeyArrowLeft = false;
        public static bool KeyArrowUp = false;
        public static bool KeyArrowDown = false;
        public static bool KeyArrowRight = false;

        public static void OnClose(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }

        public static void OnKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.Left)
            {
                KeyArrowLeft = true;
            }
            else if (e.Code == Keyboard.Key.Right)
            {
                KeyArrowRight = true;
            }
            else if (e.Code == Keyboard.Key.Up)
            {
                KeyArrowUp = true;
            }
            else if (e.Code == Keyboard.Key.Down)
            {
                KeyArrowDown = true;
            }
        }

        public static void OnKeyReleased(object sender, KeyEventArgs e)
        {
            if (e.Code == Keyboard.Key.Left)
            {
                KeyArrowLeft = false;
            }
            else if (e.Code == Keyboard.Key.Right)
            {
                KeyArrowRight = false;
            }
            else if (e.Code == Keyboard.Key.Up)
            {
                KeyArrowUp = false;
            }
            else if (e.Code == Keyboard.Key.Down)
            {
                KeyArrowDown = false;
            }
        }

        public static void OnMouseButtonPressed(object sender, MouseButtonEventArgs e)
        {
            if (e.Button == Mouse.Button.Right)
            {
                EntityManager.Character.CurrentSkill.Cast(EntityManager.Character, e.X, e.Y);
            }
        }
    }
}