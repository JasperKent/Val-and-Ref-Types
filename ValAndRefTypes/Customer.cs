using System;

namespace ValAndRefTypes
{
    public class Customer : Person
    {
        public decimal Credit { get; set; }

        public Customer()
        {

        }

        public Customer(string name, decimal credit)
            :base(name)
        {
            Credit = credit;
        }

        public override string ToString() => $"{base.ToString()} - ${Credit:c}";

        public override bool Equals(object obj) => base.Equals(obj) && Credit == ((Customer)obj).Credit;

        public override int GetHashCode() =>  HashCode.Combine(base.GetHashCode(), Credit);
    }
}
