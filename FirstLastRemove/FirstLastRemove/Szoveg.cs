﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLastRemove
{
    class Szoveg
    {
        public string Bemeno { get; set; }

        public Szoveg(string bemeno)
        {
            this.Bemeno = bemeno;
        }

        public string Remove_1()
        {
            if (this.Bemeno.Length <= 2)
            {
                return this.Bemeno;
            }
            else
            {
                return this.Bemeno.Remove(0, 1).Remove(this.Bemeno.Length - 2, 1);
            }
        }

        public string Remove_2()
        {
            if (this.Bemeno.Length <= 2)
            {
                return this.Bemeno;
            }
            else
            {
                return this.Bemeno.Substring(1, this.Bemeno.Length - 2);
            }
        }
    }
}
