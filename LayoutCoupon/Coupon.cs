using System;
using System.Collections.Generic;
using System.Text;

namespace LayoutCoupon
{
    public class Coupon
    {
        private readonly int _width;
        private StringBuilder _body = new StringBuilder();

        private List<Separators> lstSeparator = new List<Separators>();

        public Coupon(int width) => _width = width;

        public Coupon DrawCenter(string value)
        {
            var valueLength = value.Trim().Length;
            var result = Convert.ToInt32(Math.Round((double)((_width - valueLength) / 2), 0) + valueLength);
            _body.AppendLine(value.PadLeft(result));            
            return this;
        }

        public Coupon Draw(params Title[] value)
        {
            string _value = "";
            foreach (var title in value)
            {
                string wordcut = "";
                if (title.WordCut)                                    
                    wordcut = title.Value.Substring(0, title.NumberWordsCut > 0 ? title.Value.Length - title.NumberWordsCut : title.Value.Length - 5);                

                _value += wordcut.Length > 0 ? wordcut : title.Value; 
            }                

            _body.AppendLine(" " + _value);
            return this;
        }       

        public override string ToString() => _body.ToString();

        public Coupon Separator(string value)
        {
            string _value = "";
            _body.AppendLine(!string.IsNullOrEmpty((_value = (lstSeparator.Find(x => x.Separator == value) ??
                new Separators("", "")).Value)) ? _value : CreateSeparator(value));
            return this;
        }

        public Coupon Jumpline(int size)
        {
            for (int i = 0; i < size; i++)
                _body.AppendLine("");
            return this;
        }

        private string CreateSeparator(string value)
        {
            string _value = "";        
            for (int i = 0; _value.Length < _width; i++) _value += value;

            lstSeparator.Add(new Separators(value, _value));
            return _value;
        }                
    }
}