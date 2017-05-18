namespace LayoutCoupon
{
    internal class Separators
    {
        public Separators(string separator, string value)
        {
            Separator = separator;
            Value = value;
        }
        
        public string Separator { get; private set; }
        public string Value { get; private set; }
    }
}
