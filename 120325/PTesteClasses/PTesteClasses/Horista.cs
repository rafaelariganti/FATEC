﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    internal class Horista : Empregado
    {
        public double SalarioHora { get; set; }

        public double NumeroHora { get; set; }

        public int DiasFaltas { get; set; }

        public override double SalarioBruto()
        {
           return SalarioHora * NumeroHora;
        }
        
        //override indica sobreescrever
        public override int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (Convert.ToInt32(span.Days - DiasFaltas));
        }
    }
}
