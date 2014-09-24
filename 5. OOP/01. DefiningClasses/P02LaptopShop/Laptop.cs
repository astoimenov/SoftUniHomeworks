using System;
using System.Text;

namespace P02LaptopShop
{
    public class Laptop
    {
        private string model;
        private string oem;
        private string cpu;
        private int ram;
        private string gpu;
        private string drive;
        private string screen;
        private Battery battery;
        private double price;


        public Laptop(string model, double price)
        {
            this.model = model;
            this.price = price;
        }

        public Laptop(string model, double price, string cpu = null,
            string oem = null, int ram = 0, string gpu = null,
            string drive = null, string screen = null, Battery battery = null)
            : this(model, price)
        {
            this.cpu = cpu;
            this.oem = oem;
            this.ram = ram;
            this.gpu = gpu;
            this.drive = drive;
            this.screen = screen;
            this.battery = battery;
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid model!");
                }
                model = value;
            }
        }

        public string OEM
        {
            get { return oem; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid manifacturer!");
                }
                oem = value;
            }
        }

        public string CPU
        {
            get { return cpu; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid processor!");
                }
                cpu = value;
            }
        }

        public int RAM
        {
            get { return ram; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid amount of RAM!");
                }
                ram = value;
            }
        }

        public string GPU
        {
            get { return gpu; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid graphic card!");
                }
                gpu = value;
            }
        }

        public string Drive
        {
            get { return drive; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid drive!");
                }
                drive = value;
            }
        }

        public string Screen
        {
            get { return screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid screen!");
                }
                screen = value;
            }
        }

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid price!");
                }
                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Model: " + model);
            if (oem != null)
            {
                output.AppendLine("Manifacturer: " + oem);
            }
            if (cpu != null)
            {
                output.AppendLine("Processor: " + cpu);
            }
            if (ram != 0)
            {
                output.AppendLine("RAM: " + ram + " GB");
            }
            if (gpu != null)
            {
                output.AppendLine("Graphic card: " + gpu);
            }
            if (drive != null)
            {
                output.AppendLine("Drive: " + drive);
            }
            if (screen != null)
            {
                output.AppendLine("Screen:" + screen);
            }
            if (battery != null)
            {
                output.Append(battery.ToString());
            }
            output.AppendLine("Price: " + Math.Round(price) + " lv.");
            return output.ToString();
        }
    }
}
