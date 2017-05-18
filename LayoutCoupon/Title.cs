namespace LayoutCoupon
{
    public class Title
    {
        public Title(string value, int paddingLeft = 0, int paddingRight = 0)
        {
            Value = value.PadRight(paddingRight).PadLeft(paddingLeft);
            WordCut = false;
        }     

        public string Value { get; private set; }
        public bool WordCut { get; private set; }

        public int NumberWordsCut { get; private set; }

        public Title IsWordCut()
        {
            WordCut = true;
            return this;
        }

        public Title IsWordCut(int numberWordsCut)
        {
            WordCut = true;
            NumberWordsCut = numberWordsCut;
            return this;
        }
    }
}
