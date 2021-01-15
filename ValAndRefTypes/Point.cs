using System;
using System.Collections.Generic;
using System.Text;

namespace ValAndRefTypes
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString() => $"({X}, {Y})";

        public static bool operator ==(Point lhs, Point rhs)
        {
            return lhs.X == rhs.X && lhs.Y == rhs.Y;
        }

        public static bool operator !=(Point lhs, Point rhs)
        {
            return lhs.X != rhs.X || lhs.Y != rhs.Y;
        }

        public override bool Equals(object obj) => obj is Point other && this == other;

        public override int GetHashCode() => HashCode.Combine(X, Y);
    }
}
