using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_10
{
    public class BCipher: ICipher
    {

        public string Encode(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = (char)('Z' - (chars[i] - 'A'));
                }
                else if (chars[i] >= 'a' && chars[i] <= 'z')
                {
                    chars[i] = (char)('z' - (chars[i] - 'a'));
                }
            }
            return new string(chars);
        }

        public string Decode(string s)
        {
            return Encode(s); 
        }
    }
}
