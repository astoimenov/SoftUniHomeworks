namespace P03StudentClass
{
    using System;

    public class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public event EventHandler<PropertyChangedEventArgs<string>> PropertyChanged;
        
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            { 
                this.OnPropertyChanged(new PropertyChangedEventArgs<string>("Name", this.name, value));
                this.name = value; 
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.OnPropertyChanged(new PropertyChangedEventArgs<string>("Age", this.age.ToString(), value.ToString()));
                this.age = value;
            }
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs<string> e)
        {
            if (null != this.PropertyChanged)
            {
                this.PropertyChanged(this, e);
            }
        }
    }
}
