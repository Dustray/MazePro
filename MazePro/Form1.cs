﻿using StackLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazePro
{
    public partial class Form1 : Form
    {
        Random rand = new Random(); //随机数对象的实例化。不要再方法中实例化多个Random，原因见msdn
        PictureBox[,] map;  //存放pictureBox，迷宫格子
        int[,] numMap;  //保存迷宫格子的数字状态
        int[,] path;    //保存寻路的数组
        int pointX = 0; // 当前所在的位置-行，用于玩游戏时保存玩家所在的位置
        int pointY = 0; // 当前所在的位置-列
        List<Image> PathImageList = new List<Image>();  //橘黄色的背景图片
        List<Image> ImageList = new List<Image>();      //白色背景的个图片
        private static int SIDE_LENGTH = 2;
        int width = SIDE_LENGTH;    //迷宫的宽度-列数
        int height = SIDE_LENGTH;   //迷宫的高度-行数

        int chessLength = 20;
        PictureBox tmpBox;
        MyStack<BlockAttribute> stack = new MyStack<BlockAttribute>();

        //NewStack<int[]> newStack = new NewStack<int[]>(100);
        //Stack<int[]> sysStack = new Stack<int[]>(100);
        public Form1()
        {
            InitializeComponent();
            chessLength = SIDE_LENGTH > 10 ? 400 / SIDE_LENGTH : 40;
            sideLengthBar.Value = SIDE_LENGTH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initSource();
        }

        private void initSource()
        {
            ImageList.Clear();
            PathImageList.Clear();
            ////白色图片
            Checkered ch = new Checkered(chessLength);
            ImageList.Add(ch.getCheckered_0());
            ImageList.Add(ch.getCheckered_1());
            ImageList.Add(ch.getCheckered_2());
            ImageList.Add(ch.getCheckered_3());
            ImageList.Add(ch.getCheckered_4());
            ImageList.Add(ch.getCheckered_5());
            ImageList.Add(ch.getCheckered_6());
            ImageList.Add(ch.getCheckered_7());
            ImageList.Add(ch.getCheckered_8());
            ImageList.Add(ch.getCheckered_9());
            ImageList.Add(ch.getCheckered_10());
            ImageList.Add(ch.getCheckered_11());
            ImageList.Add(ch.getCheckered_12());
            ImageList.Add(ch.getCheckered_13());
            ImageList.Add(ch.getCheckered_14());
            ImageList.Add(ch.getCheckered_15());
            //橘黄色背景的图片
            Checkered ch1 = new Checkered(chessLength);
            ch1.isStepped = true;
            PathImageList.Add(ch1.getCheckered_0());
            PathImageList.Add(ch1.getCheckered_1());
            PathImageList.Add(ch1.getCheckered_2());
            PathImageList.Add(ch1.getCheckered_3());
            PathImageList.Add(ch1.getCheckered_4());
            PathImageList.Add(ch1.getCheckered_5());
            PathImageList.Add(ch1.getCheckered_6());
            PathImageList.Add(ch1.getCheckered_7());
            PathImageList.Add(ch1.getCheckered_8());
            PathImageList.Add(ch1.getCheckered_9());
            PathImageList.Add(ch1.getCheckered_10());
            PathImageList.Add(ch1.getCheckered_11());
            PathImageList.Add(ch1.getCheckered_12());
            PathImageList.Add(ch1.getCheckered_13());
            PathImageList.Add(ch1.getCheckered_14());
            PathImageList.Add(ch1.getCheckered_15());


            if (numMap != null)
            {
                numMap.Initialize();
            }
            if (path != null)
            {
                path.Initialize();
            }

        }

        //按钮-创建迷宫
        private void btn_createMap_Click(object sender, EventArgs e)
        {
            startCreateMap();
        }
        private void startCreateMap()
        {
            clearMaze();//格式化资源

            //btn_createMap.Enabled = false;
            path = new int[height, width];//寻路的数组
            map = new PictureBox[height, width];//格子图片数组
            numMap = new int[height, width];//格子数字状态
            drawCheckerboar();
            CreateNumMap((int)height / 2, (int)width / 2, 0);//在迷宫的中间开始遍历
            //CreateNumMap(0, 0, 0);
            CreateMap();
        }

        //绘制pictureBox，数组数据初始化
        public void drawCheckerboar()
        {

            int currentPoint = 0;
            int initX = 10;
            int initY = 10;
            int _x = initX;
            int _y = initY;



            //tmpBox.Controls.Clear();

            for (int x = 0; x < height * width; x++)
            {
                if (currentPoint % width == 0)
                {
                    _x = initX;
                    _y = ((int)currentPoint / width) * chessLength + initY;
                }
                else
                {
                    _x += chessLength;
                }
                tmpBox = new PictureBox();
                tmpBox.Name = "ss";
                tmpBox.Left = _x;
                tmpBox.Top = _y;
                tmpBox.Width = chessLength;
                tmpBox.Height = chessLength;
                map[(int)currentPoint / width, currentPoint % width] = tmpBox;
                numMap[(int)currentPoint / width, currentPoint % width] = -1;   //-1表示未遍历过
                mazeBox.Controls.Add(tmpBox);
                tmpBox = null;

                currentPoint++;
            }
        }

        //创建迷宫状态数据
        private void CreateNumMap(int m, int n, int o)
        {
            List<int> directs = new List<int> { 0, 1, 2, 3 };   //存储未用的方向。0123分别表示上-右-下-左
            int last = 0;
            switch (o)
            {
                case 1:
                    last = 4;
                    break;
                case 2:
                    last = 8;
                    break;
                case 4:
                    last = 1;
                    break;
                case 8:
                    last = 2;
                    break;
            }
            numMap[m, n] = last;

            //test-begin
            string s1 = "";
            for (int i = 0; i < SIDE_LENGTH; i++)
            {
                s1 += (i < 10 ? "0" + i : "" + i) + " ";
            }
            s1 += "\r\n\r\n";
            string s = "";
            for (int f = 0; f < height; f++)
            {
                for (int g = 0; g < width; g++)
                {
                    int s2 = numMap[f, g];

                    s += (s2 < 10 ? "0" + s2 : "" + s2) + " ";
                }
                s += "\r\n";
            }
            txt_str.Text = s1 + s;
            //test-end
            while (directs.Count > 0)
            {
                int x = m;
                int y = n;
                int d = rand.Next(directs.Count);
                int t = 0;
                switch (directs[d])
                {
                    case 0:
                        x--;
                        t = 8;
                        break;
                    case 1:
                        y++;
                        t = 4;
                        break;
                    case 2:
                        x++;
                        t = 2;
                        break;
                    case 3:
                        y--;
                        t = 1;
                        break;
                }
                directs.RemoveAt(d);    //删除使用过的方向
                if (x < height && y < width && x >= 0 && y >= 0 && numMap[x, y] == -1)//没有超出数组边界，格子未被遍历过，则为true
                {
                    last = t ^ last;    //异或操作
                    numMap[m, n] = last;
                    //test-begin
                    string ss = "";
                    for (int f = 0; f < height; f++)
                    {
                        for (int g = 0; g < width; g++) ss += numMap[f, g].ToString() + " ";
                        ss += "\r\n";
                    }
                    txt_str.Text = ss;
                    //test-end
                    CreateNumMap(x, y, t);  //递归操作
                }
            }
        }

        //生成迷宫
        private void CreateMap()
        {
            numMap[0, 0] = numMap[0, 0] ^ 8;//对8与操作，打开一个缺口，作为进入口。
            numMap[height - 1, width - 1] = numMap[height - 1, width - 1] ^ 2;//打开一个缺口作为出去口。
            for (int m = 0; m < height; m++)
            {
                for (int n = 0; n < width; n++)
                {
                    int x = numMap[m, n];

                    map[m, n].Image = ImageList[x];
                }
            }
            map[0, 0].Image = PathImageList[numMap[0, 0]]; //给第一格子换成橘黄色的背景
        }

        //寻路
        private void Pathfinding(int x, int y)
        {
            if (x == height - 1 && y == width - 1)
            {
                for (int f = 0; f < height; f++)
                {
                    for (int g = 0; g < width; g++)
                    {
                        if (path[f, g] != 0)
                        {
                            map[f, g].Image = PathImageList[numMap[f, g]];
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= 3; i++)
                {
                    int m = x;
                    int n = y;
                    int direct = 0;
                    switch (i)
                    {
                        case 0:
                            m--;
                            direct = 8;
                            break;
                        case 1:
                            n++;
                            direct = 4;
                            break;
                        case 2:
                            m++;
                            direct = 2;
                            break;
                        case 3:
                            n--;
                            direct = 1;
                            break;
                    }
                    if (m < height && n < width && m >= 0 && n >= 0 && (numMap[x, y] & direct) != 0 && path[m, n] == 0)
                    {
                        path[x, y] = 1;
                        Pathfinding(m, n);
                        path[x, y] = 0;
                    }
                }
            }
        }

        //按钮
        private void btn_test_Click(object sender, EventArgs e)
        {
            Pathfinding(0, 0);
        }

        //重写键盘事件,用于走迷宫
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                if (stack.StackEmpty())
                {
                    MessageBox.Show("无法撤销");
                    return false;
                }
            }
            if (numMap != null)
            {
                int m = pointX;
                int n = pointY;
                int direct = 0;
                switch (keyData)
                {
                    case Keys.Up:
                        m--;
                        direct = 8;
                        break;
                    case Keys.Down:
                        m++;
                        direct = 2;
                        break;
                    case Keys.Left:
                        n--;
                        direct = 1;
                        break;
                    case Keys.Right:
                        n++;
                        direct = 4;
                        break;
                    case (Keys.Control | Keys.Z):

                        BlockAttribute block = stack.GetTop();
                        switch (block.blockDirect)
                        {
                            case 8:
                                direct = 2;
                                break;
                            case 2:
                                direct = 8;
                                break;
                            case 1:
                                direct = 4;
                                break;
                            case 4:
                                direct = 1;
                                break;
                        }
                        //direct = 10;
                        break;
                    default:
                        return false;
                }
                //MessageBox.Show("--m  "+m + "--n  " + n + "--pointX  " + pointX + "--pointY  " + pointY + "--direct  "+direct);
                if (m < height && n < width && m >= 0 && n >= 0 && (numMap[pointX, pointY] & direct) != 0)
                {


                    if (keyData == (Keys.Control | Keys.Z))
                    {

                        BlockAttribute block = stack.Pop();
                        map[pointX, pointY].Image = ImageList[numMap[pointX, pointY]];//将未被踩的贴到原位置
                        map[block._X, block._Y].Image = PathImageList[numMap[block._X, block._Y]];//将已被踩的贴到新的位置
                        status_lb_x.Text = block._X.ToString();
                        status_lb_y.Text = block._Y.ToString();
                        pointX = block._X;
                        pointY = block._Y;
                    }
                    else
                    {

                        stack.Push(new BlockAttribute(pointX, pointY, direct));//将原位置入栈
                        map[pointX, pointY].Image = ImageList[numMap[pointX, pointY]];//将未被踩的贴到原位置
                        map[m, n].Image = PathImageList[numMap[m, n]];//将已被踩的贴到新的位置
                        status_lb_x.Text = m.ToString();
                        status_lb_y.Text = n.ToString();
                        pointX = m;
                        pointY = n;
                    }


                    if (m == height - 1 && n == width - 1)
                    {
                        MessageBox.Show("win!");
                        if(winAndNewGame.Checked)
                            startCreateMap();
                    }
                    return true;
                }
            }
            //return base.ProcessCmdKey(ref msg, keyData);
            return true;
        }

        private void test_Click(object sender, EventArgs e)
        {
            Checkered ch = new Checkered();
            //pictureBox1.Image = ch.getCheckered_14();

        }

        private void sideLengthBar_Scroll(object sender, EventArgs e)
        {
            SIDE_LENGTH = sideLengthBar.Value;
            showLevel.Text = "" + SIDE_LENGTH;
            width = SIDE_LENGTH;    //迷宫的宽度-列数
            height = SIDE_LENGTH;   //迷宫的高度-行数
            chessLength = SIDE_LENGTH > 10 ? 400 / SIDE_LENGTH : 40;
            initSource();
        }
        private void clearMaze()
        {

            //删除当前图层
            mazeBox.Controls.Clear();
            //设置用户位置为0
            pointX = pointY = 0;

            //初始化numMap数组
            if (numMap != null)
            {
                numMap.Initialize();
            }
            //初始化Path数组
            if (path != null)
            {
                path.Initialize();
            }
            //清空栈记录
            stack.ClearStack();
        }
    }
}