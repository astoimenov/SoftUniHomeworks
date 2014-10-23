namespace P02StringDisperser
{
    using System;
    using System.Collections;
    using System.Reflection;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string[] inputStrings;

        public StringDisperser(params string[] strings)
        {
            this.inputStrings = strings;
        }

        public string[] InputStrings
        {
            get { return this.inputStrings; }
            set { this.inputStrings = value; }
        }

        public static bool operator ==(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return string.Equals(stringDisperser1, stringDisperser2);
        }

        public static bool operator !=(StringDisperser stringDisperser1, StringDisperser stringDisperser2)
        {
            return !string.Equals(stringDisperser1, stringDisperser2);
        }

        public override bool Equals(object obj)
        {
            StringDisperser stringDisperser = obj as StringDisperser;
            return stringDisperser != null && this.inputStrings.Equals(stringDisperser.inputStrings);
        }

        public override int GetHashCode()
        {
            PropertyInfo[] theProperties = this.GetType().GetProperties();
            int hash = 31;
            foreach (PropertyInfo info in theProperties)
            {
                if (info != null)
                {
                    var value = info.GetValue(this, null);
                    if (value != null)
                    {
                        unchecked
                        {
                            hash = 29 * hash ^ value.GetHashCode();
                        }
                    }
                }
            }

            return hash;
        }

        public int CompareTo(StringDisperser other)
        {
            return string.CompareOrdinal(this.ToString(), other.ToString());
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.inputStrings);
        }

        public object Clone()
        {
            StringDisperser clonedDisperser = new StringDisperser(this.inputStrings);
            return clonedDisperser;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.ToString().Length; i++)
            {
                yield return this.ToString()[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
