using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DProject
{
    public partial class Form1 : Form
    {
        int a;
        Triangle3D t;
        Matrix4x4 m_Scale;
        Matrix4x4 m_RotateY;
        Matrix4x4 m_RotateX;
        Matrix4x4 m_RotateZ;
        Matrix4x4 m_view;
        Matrix4x4 m_Projection;
        public Form1()
        {
            InitializeComponent();
            m_Scale = new Matrix4x4();
            m_RotateY = new Matrix4x4();
            m_Scale[1, 1] = 250;
            m_Scale[2, 2] = 250;
            m_Scale[3, 3] = 250;
            m_Scale[4, 4] = 1;
            m_RotateX = new Matrix4x4();
            m_RotateZ = new Matrix4x4();
            m_view = new Matrix4x4();//实际是个平移
            m_view[1, 1] = 1;
            m_view[2, 2] = 1;
            m_view[3, 3] = 1;
            m_view[4, 3] = 250;//z轴平移的意义同  摄像z轴负方向平移一样
            m_view[4, 4] = 1;
            m_Projection = new Matrix4x4();
            m_Projection[1, 1] = 1;
            m_Projection[2, 2] = 1;
            m_Projection[3, 3] = 1;
            m_Projection[3, 4] = 1.0 / 250; //250位距离系数

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vector4 a = new vector4(0, 0.5, 0, 1);//只有第四个点位1  矩阵乘法才成立 所以最后一位要求是1
            vector4 b = new vector4(0.5, -0.5, 0, 1);
            vector4 c = new vector4(-0.5, -0.5, 0, 1);
            t = new Triangle3D(a, b, c);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            t.Draw(e.Graphics);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 2;
            double angle = a / 360.0 * Math.PI;//角度转化弧度
            m_RotateY[1, 1] = Math.Cos(angle);
            m_RotateY[1, 3] = Math.Sin(angle);
            m_RotateY[2, 2] = 1;
            m_RotateY[3, 1] = -Math.Sin(angle);
            m_RotateY[3, 3] = Math.Cos(angle);
            m_RotateY[4, 4] = 1;

            m_RotateX[1, 1] = 1;
            m_RotateX[2, 2] = Math.Cos(angle);
            m_RotateX[2, 3] = Math.Sin(angle);
            m_RotateX[3, 2] = -Math.Sin(angle);
            m_RotateX[3, 3] = Math.Cos(angle);
            m_RotateX[4, 4] = 1;

            m_RotateZ[1, 1] = Math.Cos(angle);
            m_RotateZ[1, 2] = Math.Sin(angle);
            m_RotateZ[2, 1] = -Math.Sin(angle);
            m_RotateZ[2, 2] = Math.Cos(angle);
            m_RotateZ[3, 3] = 1;
            m_RotateZ[4, 4] = 1;
            //旋转为正交矩阵 所以 其逆矩阵就是本身的转制

            if (CBX.Checked)
            {
                Matrix4x4 tx = m_RotateX.Transpose();
                m_RotateX = m_RotateX.Mul(tx);
            }
            if (CBY.Checked)
            {
                Matrix4x4 tx = m_RotateY.Transpose();
                m_RotateY = m_RotateY.Mul(tx);
            }
            if (CBZ.Checked)
            {
                Matrix4x4 tx = m_RotateZ.Transpose();
                m_RotateZ = m_RotateZ.Mul(tx);
            }
            //
            Matrix4x4 m = new Matrix4x4();
            Matrix4x4 Mall = m_RotateX.Mul(m_RotateY).Mul(m_RotateZ);
            m = m_Scale.Mul(Mall);//模型到世界          
            Matrix4x4 mv = m.Mul(m_view);
            Matrix4x4 mvp = m.Mul(m_Projection);
            t.TransForm(m);
            this.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            m_view[4, 3] = (sender as TrackBar).Value;
        }


    }
}
