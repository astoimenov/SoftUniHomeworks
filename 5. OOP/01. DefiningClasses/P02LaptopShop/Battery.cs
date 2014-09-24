using System;
using System.Text;

namespace P02LaptopShop
{
    public class Battery
    {
        private string type;
        private int cells;
        private int capacity;
        private double batteryLife;

        public Battery(string type, double batteryLife)
        {
            this.Type = type;
            this.Cells = cells;
            this.BatteryLife = batteryLife;
        }

        public Battery(string type, double batteryLife, int cells = 0, int capacity = 0)
            : this(type, batteryLife)
        {
            this.Cells = cells;
            this.Capacity = capacity;
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Ivalid battery type!");
                }
                type = value;
            }
        }

        public int Cells
        {
            get { return cells; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number of cells!");
                }
                cells = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid battery capacity!");
                }
                capacity = value;
            }
        }

        public double BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid battery life!");
                }
                batteryLife = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("Battery: " + type + ", ");
            output.Append(cells + "-cells, ");
            output.AppendLine(capacity + "mAh");
            output.AppendLine("Battery life: " + batteryLife + " hours");
            return output.ToString();
        }
    }
}
