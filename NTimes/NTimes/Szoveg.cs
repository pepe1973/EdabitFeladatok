using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTimes
{
    class Szoveg
    {
        public string Bemeno { get; set; }

        public Szoveg(string bemeno)
        {
            this.Bemeno = bemeno;
        }

        public string Ismetel(int hanyszor)
        {
            string kimeno = "";

            if (this.Bemeno.Length == 0)
            {
                return kimeno = "Üres sztringgel nem tudok dolgozni!";
            }
            else
            {
                for (int i = 0; i < this.Bemeno.Length; i++)
                {
                    for (int j = 0; j < hanyszor; j++)
                    {
                        kimeno = String.Concat(kimeno, this.Bemeno[i]);
                    }
                }

                return kimeno;
            }
        }
    }
}
