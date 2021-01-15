using System;

namespace ValAndRefTypes
{
    public class Employee : Person
    {
        public string Department { get; set; }

        public Employee()
        {

        }

        public Employee(string name, string department)
            :base(name)
        {
            Department = department;
        }

        public override string ToString() => $"{base.ToString()} - {Department}";

        public override bool Equals(object obj) => base.Equals(obj) && Department == ((Employee)obj).Department;

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Department);
    }
}
