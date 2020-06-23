using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DProject
{
    class Triangle3D
    {
        public vector4 a, b, c; //世界空间定点
        public vector4 A, B, C;// 模型空间顶点
        private float  dot;
        public Triangle3D() { }
        public Triangle3D(vector4 a, vector4 b, vector4 c)
        {
            this.A = this.a = new vector4(a);
            this.B = this.b = new vector4(b);
            this.C = this.c = new vector4(c);
        }
        //三角形利用矩阵乘法变换  传入变换矩阵
        public void TransForm(Matrix4x4 m)
        {
            //为了避免 double 类型反复相乘的 数据精确度下降  每次都是用原始数据相乘
            this.a = m.Mul(this.A);
            this.b = m.Mul(this.B);
            this.c = m.Mul(this.C);
        }
        //绘制三角形到2d 窗口上

        //
        public void CalculateLighting( Matrix4x4 _Object2world, vector4 L)
        {
            this.TransForm( _Object2world);//直接完成世界坐标的变换
            vector4 U = this.b - this.a;
            vector4 V = this.c - this.a;
            vector4 normal = U.Cross(V);
            dot = normal.Noralized.Dot(L.Noralized);//得到夹角
            dot = Math.Max(0, dot);
        }
        public void Draw(Graphics g)
        {
            g.TranslateTransform(300, 300);//挪动坐标原点
            g.DrawLines(new Pen(Color.Black,2), this.Get2DPointfArr());
            GraphicsPath path = new GraphicsPath();
            path.AddLines(this.Get2DPointfArr());
            int r = (int)(200 * dot)+55;//保证不会全黑 最低55
            Color color = Color.FromArgb(r,r,r);
            Brush br = new SolidBrush(color);
            g.FillPath(br, path);
                     
        }
        private PointF[] Get2DPointfArr()
        {
            PointF[] arr = new PointF[4];
            arr[0] = Get2DPointF(this.a);//将 此三角形的 定点转化为 2D投影点
            arr[1] = Get2DPointF(this.b);
            arr[2] = Get2DPointF(this.c);
            arr[3] = Get2DPointF(this.a);
            return arr;
        }
        /// <summary>
        /// 把四维 点 转化为投影平面的 2D点
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private PointF Get2DPointF(vector4 v)
        {
            PointF p = new PointF();
            p.X = (float)(v.x / v.w);//透视除法 向量分量 除以 w分量
            p.Y = -(float)(v.y / v.w);
            return p;
        }
    }
}
