using System;

namespace MembrosStaticos
{
    class ConcversorDeMoeda
    {

        public static double Iof = 6.0;

        public static double CalcularCotacao(double quantia, double cot)
        {

            double total = quantia * cot;

            return total + total * Iof / 100.0;

        }
    }
}

