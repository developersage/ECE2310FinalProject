using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Temperature
    {
        private double degree;
        private char scale;

        public Temperature()
        {
            degree = 0;
            scale = 'F';
        }

        public Temperature(double num)
        {
            degree = num;
            scale = 'F';
        }
        public Temperature(double num, char a)
        {
            degree = num;
            if (a == 'F' || a == 'C' || a == 'K')
            {
                scale = a;
            }
            else
            {
                scale = 'F';
            }
        }
        public double Degree
        {
            get => degree; set => degree = value;
        }
        public char Scale
        {
            get => scale;
            set
            {
                if (value == 'F' || value == 'C' || value == 'F')
                {
                    scale = value;
                }
            }
        }
        public override string ToString()
        {
            return String.Format("{0}°{1}", degree, scale);
        }
    }
}
