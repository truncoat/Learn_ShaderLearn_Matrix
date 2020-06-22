using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class Matrix4x4
    {
        private double[,] pts;
        public Matrix4x4()
        {
            pts = new double[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0;j < 4;  j++)
                {
                    pts[i, j] = 0;
                }
            }
        }
        public double this[int i, int j] {
            get {
                return pts[i - 1, j - 1];
            }
            set {
                pts[i - 1, j - 1] = value;
            }
        }

        public Matrix4x4 Mul(Matrix4x4 m)
        {
            Matrix4x4 newM = new Matrix4x4();
            for (int w = 1; w <= 4; w++)
            {
                for (int h = 1; h <= 4; h++)
                {
                    for (int n = 1; n <= 4; n++)
                    {
                        newM[w, h] += this[w, n] * m[n, h];// 本地当前行 当前列 等于 本体当前行的 四列内单数 乘以 对方四行中当前列的和
                    }
                }
            }
            return newM;
        }

        public vector4 Mul(vector4 v)
        {
            vector4 newV = new vector4();
            newV.x = v.x * this[1, 1] + v.y * this[2, 1] + v.z * this[3, 1] + v.w * this[4, 1];
            newV.y = v.x * this[1, 2] + v.y * this[2, 2] + v.z * this[3, 2] + v.w * this[4, 2];
            newV.z = v.x * this[1, 3] + v.y * this[2, 3] + v.z * this[3, 3] + v.w * this[4, 3];
            newV.w = v.x * this[1, 4] + v.y * this[2, 4] + v.z * this[3, 4] + v.w * this[4, 4];
            return newV;
        }

        /// <summary>
        /// 求矩阵的 转制矩阵
        /// </summary>
        /// <returns></returns>
        public Matrix4x4 Transpose()
        {
            Matrix4x4 t = new Matrix4x4();
            //得到转制矩阵
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    t[i, j] = this[j, i];
                }
            }
            return t;
        }

    }


}
