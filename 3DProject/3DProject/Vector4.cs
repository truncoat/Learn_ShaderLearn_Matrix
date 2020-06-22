using System;
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

        public static vector4 operator -(vector4 a, vector4 b)
        {
            return new vector4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }
        /// <summary>
        /// 向量叉乘 得到法向量
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public vector4 Cross(vector4 v)
        {
            return new vector4(this.y * v.z - this.z * v.y, this.z * v.x - this.x * v.z, this.x * v.y - this.y - v.x, 0);
        }
        /// <summary>
        /// 向量点积得到 夹角
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public float Dot(vector4 v)
        {
            return (float)(this.x * v.x + this.y * v.y + this.z * v.z);
        }
    }
}
