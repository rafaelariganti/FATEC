﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    internal class Mensalista : Empregado
    {
        public Double SalarioMensal {  get; set; }

        //sobreescrevendo o método

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }
    }
}
