namespace OperatorOverloading
{
    class Fraction
    {
        private readonly int num;
        private readonly int den;

        public Fraction(int numerator, int denominator)
        {
            if(den == 0)
            {
                throw new ArgumentException("Denominator cannot be 0", nameof(denominator));
            }
            num = numerator; den = denominator; 
        }
        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction c = a + (-b);
            return c;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(((a.num* b.den) + (b.num * a.den)), a.den*b.den);
            return c;
        }

        public static bool operator == (Fraction a, Fraction b)
        {
            return a.num == b.num && a.den == b.den;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.num != b.num || a.den != b.den;
        }

        public override string ToString()
        {
            return $"{num} / {den}";
        }
    }

}
