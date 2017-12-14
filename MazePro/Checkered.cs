using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePro
{
    class Checkered
    {
        private int SideLength { get; set; }
        private int Thickness { get; set; }
        public bool isStepped { get; set; }


        public Checkered()
        {
            SideLength = 20;
            Thickness = 2;
            isStepped = false;
        }
        public Checkered(int size)
        {
            SideLength = size;
            Thickness = 2;
            isStepped = false;
        }

        public Image getCheckered_15()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画四个点
            MyImage = GenerateDot(MyImage);
            return MyImage;

        }
        public Image getCheckered_14()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画左面线
            return DrawLeftLine(MyImage);
        }
        public Image getCheckered_13()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画底面线
            return DrawBottomLine(MyImage);
        }
        public Image getCheckered_12()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画左下面线
            MyImage = DrawBottomLine(MyImage);
            return DrawLeftLine(MyImage);
        }
        public Image getCheckered_11()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画右面线
            return DrawRightLine(MyImage);
        }
        public Image getCheckered_10()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画左右面线
            MyImage = DrawRightLine(MyImage);
            return DrawLeftLine(MyImage);
        }
        public Image getCheckered_9()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画右下面线
            MyImage = DrawBottomLine(MyImage);
            return DrawRightLine(MyImage);
        }
        public Image getCheckered_8()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画右下左面线
            MyImage = DrawRightLine(MyImage);
            MyImage = DrawBottomLine(MyImage);
            return DrawLeftLine(MyImage);
        }
        public Image getCheckered_7()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画上面线
            return DrawTopLine(MyImage);
        }
        public Image getCheckered_6()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画左上面线
            MyImage = DrawTopLine(MyImage);
            return DrawLeftLine(MyImage);
        }
        public Image getCheckered_5()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画上下面线
            MyImage = DrawTopLine(MyImage);
            return DrawBottomLine(MyImage);
        }
        public Image getCheckered_4()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画上左下面线
            MyImage = DrawTopLine(MyImage);
            MyImage = DrawBottomLine(MyImage);
            return DrawLeftLine(MyImage);
        }
        public Image getCheckered_3()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画上右面线
            MyImage = DrawTopLine(MyImage);
            return DrawRightLine(MyImage);
        }
        public Image getCheckered_2()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画左上右面线
            MyImage = DrawRightLine(MyImage);
            MyImage = DrawTopLine(MyImage);
            return DrawLeftLine(MyImage);
        }
        public Image getCheckered_1()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
             //画上右下面线
            MyImage = DrawBottomLine(MyImage);
            MyImage = DrawTopLine(MyImage);
            return DrawRightLine(MyImage);
        }
        public Image getCheckered_0()
        {
            Image MyImage = new Bitmap(SideLength, SideLength);//申请位图对象
            //画上下左右面线
            MyImage = DrawTopLine(MyImage);
            MyImage = DrawRightLine(MyImage);
            MyImage = DrawBottomLine(MyImage);
            return DrawLeftLine(MyImage);
        }

        /**
         *左线 
         */
        private Image DrawLeftLine(Image MyImage)
        {
            return GenerateLine(MyImage, 0, 0, 0, SideLength); 
        }
        /**
         *底线 
         */
        private Image DrawBottomLine(Image MyImage)
        {
            return GenerateLine(MyImage, 0, SideLength, SideLength, SideLength);
        }
        /**
         *右线 
         */
        private Image DrawRightLine(Image MyImage)
        {
            return GenerateLine(MyImage, SideLength, 0, SideLength, SideLength);
        }
        /**
         *顶线 
         */
        private Image DrawTopLine(Image MyImage)
        {
            return GenerateLine(MyImage, 0, 0, SideLength, 0);
        }


        public Image GenerateLine(Image MyImage, int x1,int y1,int x2,int y2)
        {
           
            Pen p = new Pen(Color.Black, Thickness);//设置笔的粗细为5,颜色为蓝色
            p.DashStyle = DashStyle.Solid;//定义虚线的样式为点
            Graphics g = Graphics.FromImage(MyImage); //申请画图对象
            if (isStepped)
            {
                //寻路填充颜色
                Color color = Color.FromArgb(3, 169, 244);
                Pen ps = new Pen(color, 4);//定义了一个蓝色,宽度为的画笔
                g.DrawRectangle(ps, 3*SideLength/8, 3*SideLength/8, SideLength /4,  SideLength / 4);//在画板上画矩形,起始坐标为(10,10),宽为,高为
            }
            //画线
            g.DrawLine(p, x1, y1, x2, y2);
            //画一个象素的点
            //MyBitmap.SetPixel(x, y, Color.White);
            g.DrawImage(MyImage, 0, 0, SideLength, SideLength); //pictureBox1在(0,0)到(h,w)范围画点
            return MyImage;     //这个图片贴到pictureBox1控件上
        }

        public Image GenerateDot(Image MyImage)
        {
            Graphics g = Graphics.FromImage(MyImage); //申请画图对象
            if (isStepped)
            {
                //寻路填充颜色
                Color color = Color.FromArgb(3, 169, 244);
                Pen ps = new Pen(color, 4);//定义了一个蓝色,宽度为的画笔
                g.DrawRectangle(ps, 3 * SideLength / 8, 3 * SideLength / 8, SideLength / 4, SideLength / 4);//在画板上画矩形,起始坐标为(10,10),宽为,高为
            }
          
            return MyImage;     //这个图片贴到pictureBox1控件上
        }
    }
}
