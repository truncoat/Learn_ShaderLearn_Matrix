﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class vector4

    {
        public double x, y, z, w;
        public vector4() { }
        public vector4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;

        }
        public vector4(vector4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        public static vector4 operator -( vector4 a,vector4 b)
        {
            return new vector4(a.x-b.x,a.y-b.y,a.z-b.z,a.w-b.w);
        }
    }
}
