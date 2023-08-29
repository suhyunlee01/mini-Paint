using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniPaint
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point ptStart;
        private Point ptEnd;
        private Rectangle rect;
        private Boolean bPress; //마우스 누르고 떼고 true false 스위치 제작
        private int shape; //모양이 뭔지 알 수 있는 스위치 제작
        private Pen myPen;
        private int rtWidth; //사각형 너비 저장
        private int rtHeight; //사각형 높이 저장

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //생성자에서 초기화하지 않고 늦은 초기화를 함.
            //객체가 생성되지 않았는데 미리 동작되어서 에러가 나는 경우가 생길 수 있기 때문임.

            ptStart = new Point(0, 0);
            ptStart = new Point(0, 0);
            bPress = false;
            shape = 0; //직선:0, 사각형:1, 원:2
            myPen = new Pen(Color.Black, 1);
            rtWidth = 0;
            rtHeight = 0;
            //paint 이벤트를 쓰지 않기 때문에 직접 그래픽스 객체를 가져와서 화면에 출력해야함.
            //Handle로 부터 그래픽스 객체를 가져옴
            g = Graphics.FromHwnd(this.Handle);
            //this는 Form1의 객체임. Handle은 Control 클래스의 속성이고, Form은 Control을 상속받기 때문에 this.Handle이 가능함.

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e) //시작좌표 설정
        {
            bPress = true; //마우스 누름
            //마우스를 누른 곳의 시작점 가져오기
            ptStart.X = e.X;
            ptStart.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //그리기
        {
            if (shape == 0) //도형이 직선일 경우
            {
                if (bPress == true)
                {
                    //잔상을 지우기 위해 전체 화면 지우고 지정된 배경색으로 화면 채우기
                    g.Clear(Color.White);
                    ptEnd = new Point(e.X, e.Y);
                    g.DrawLine(myPen, ptStart, ptEnd);
                }
            }
            else if (shape == 1) //도형이 사각형일 경우
            {
                if (bPress == true)
                {
                    g.Clear(Color.White);
                    rtWidth = Math.Abs(e.X - ptStart.X); //너비: x좌표 - 그리기시작좌표 //절대값으로 변경(양수)
                    rtHeight = Math.Abs(e.Y - ptStart.Y); //높이 : Y좌표 - 그리기시작좌표 

                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight); //사각형 초기화
                    g.DrawRectangle(myPen, rect);
                }
            }
            else if (shape == 2) //도형이 원일 경우
            {
                if (bPress == true)
                {
                    g.Clear(Color.White);
                    rtWidth = Math.Abs(e.X - ptStart.X); //너비: x좌표 - 그리기시작좌표 //절대값으로 변경(양수)
                    rtHeight = Math.Abs(e.Y - ptStart.Y); //높이 : Y좌표 - 그리기시작좌표 

                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight); //사각형 초기화
                    g.DrawEllipse(myPen, rect);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (shape == 0)
            {
                ptEnd = new Point(e.X, e.Y);
                g.DrawLine(myPen, ptStart, ptEnd);
            }
            else if (shape == 1)
            {
                rtWidth = Math.Abs(e.X - ptStart.X); //너비: x좌표 - 그리기시작좌표 //절대값으로 변경(양수)
                rtHeight = Math.Abs(e.Y - ptStart.Y); //높이 : Y좌표 - 그리기시작좌표 

                rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight); //사각형 초기화
                g.DrawRectangle(myPen, rect);
            }
            else if (shape == 2)
            {
                rtWidth = Math.Abs(e.X - ptStart.X); //너비: x좌표 - 그리기시작좌표 //절대값으로 변경(양수)
                rtHeight = Math.Abs(e.Y - ptStart.Y); //높이 : Y좌표 - 그리기시작좌표 

                rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight); //사각형 초기화
                g.DrawEllipse(myPen, rect);
            }
            bPress = false;
        }


        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripLine_Click(object sender, EventArgs e)
        {
            this.shape = 0;
        }

        private void ToolStripRect_Click(object sender, EventArgs e)
        {
            this.shape = 1;
        }

        private void ToolStripCircle_Click(object sender, EventArgs e)
        {
            this.shape = 2;
        }

        private void ToolStripColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.colorDialog1.ShowDialog()) //ColorDialog 설정하고, 확인버튼이 눌려졌을 때
            {
                this.myPen.Color = this.colorDialog1.Color; //펜의 컬러를 ColorDialog의 컬러로 변경하기
            }
        }

        private void toolStripbtnLine_Click(object sender, EventArgs e)
        {
            this.shape = 0;
        }

        private void toolStripbtnRect_Click(object sender, EventArgs e)
        {
            this.shape = 1;
        }

        private void toolStripbtnCircle_Click(object sender, EventArgs e)
        {
            this.shape = 2;
        }

        private void toolStripbtnBlack_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Black;
        }

        private void toolStripbtnRed_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Red;
        }

        private void toolStripbtnBlue_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Blue;
        }

        private void toolStripbtnGreen_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Green;
        }

        private void toolStripComboTick_SelectedIndexChanged(object sender, EventArgs e)
        {
            //펜의 굵기 속성: Width 임
            //툴스트립 중 선택한 아이템(1~5)을 펜의 굵기로 설정
            this.myPen.Width = int.Parse(this.toolStripComboTick.SelectedItem.ToString());
        }
    }
}