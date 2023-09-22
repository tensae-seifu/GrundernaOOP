using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Grunderna_OOP
{
    internal class Triangle
    {
        public int _Base;
        public int _Height;
        public float constant = 0.5f;


        public Triangle(int Base, int Height)
        {
            this._Base = Base;
            this._Height = Height;

        }

        public float GetArea(int _Base, int _Height)
        {
            return (constant) * _Base * _Height;
        }




    }
}
