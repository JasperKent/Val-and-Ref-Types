using System;

namespace ValAndRefTypes
{
    public class Person
    {
        public string Name { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;

        public override bool Equals(object obj) => obj != null && GetType() == obj.GetType() && Name == ((Person)obj).Name;

        public override int GetHashCode() => Name.GetHashCode();
    }
}
