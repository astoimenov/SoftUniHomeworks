namespace P03StudentClass
{
    using System;

    public class PropertyChangedEventArgs<T> : EventArgs
    {
        public PropertyChangedEventArgs(string name, T oldValue, T newValue)
        {
            this.Name = name;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string Name { get; set; }

        public T OldValue { get; set; }

        public T NewValue { get; set; }
    }
}
