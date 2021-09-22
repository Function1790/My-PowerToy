using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixels
{
    public partial class Pixels : Form
    {
        //상수  
        const int FrameSize = 70;
        const float Gravity = 1;

        //변수
        public static Block[,] frame=new Block[FrameSize, FrameSize];
        public static Type now=Type.Sand;
        public static bool is_Held = false;
        public static Point pos1 = new Point(0, 0);
        public static Label ifLabel=new Label();
        public static Point SelectPos = new Point(0, 0);

        //물질의 종류
        public enum Type
        {
            Air,
            Glass,
            Sand,
            Water,
            Oil,
            Fire,
            Ice
        }

        //물질의 상태
        public enum Status
        {
            Solid,
            Liquid,
            Dust,
            Gas,
            Energy,
            None
        }

        //절대값
        public static int absolute(int value)
        {
            if (value < 0)
            {
                return -value;
            }
            return value;
        }

        public static double absolute(double value)
        {
            if (value < 0)
            {
                return -value;
            }
            return value;
        }

        //로깅
        public static void Log(string title, object content)
        {
            Console.WriteLine($"[{title}] : {content}");
        }

        //Fill
        public static void Fill(Point pos1, Point pos2)
        {
            Point p1 = pos1;
            Point p2 = pos2;
            if (pos1.X > pos2.X)
            {
                p1.X = pos2.X;
                p2.X = pos1.X;
            }
            if (pos1.Y > pos2.Y)
            {
                p1.Y = pos2.Y;
                p2.Y = pos1.Y;
            }

            for (int i = 0; i < p2.Y - p1.Y + 1; i++)
            {
                for (int j = 0; j < p2.X - p1.X + 1; j++)
                {
                    try
                    {
                        if(frame[p1.Y + i, p1.X + j].panel.BorderStyle == BorderStyle.Fixed3D)
                        {
                            frame[p1.Y + i, p1.X + j].panel.BorderStyle = BorderStyle.None;
                        }
                        if (now == Type.Air)
                        {
                            frame[p1.Y + i, p1.X + j].setType(now);
                        }
                        else if (frame[p1.Y + i, p1.X + j].type == Type.Air)
                        {
                            frame[p1.Y + i, p1.X + j].setType(now);
                        }
                    }
                    catch (Exception) { }
                }
            }
            Log("Fill", $"type = {now}, from = {p1}, to = {p2}");
        }

        //info 설정
        public static void setInfo()
        {
            Block b = frame[SelectPos.Y, SelectPos.X];
            string info = "";
            info += $"Type : {b.type}\n";
            info += $"Stat : {b.status}\n";
            info += $"Life : {(int)(b.life * 10000)}\n";
            info += $"Temp : {b.temperature}\n";
            info += $"Dens : {b.density}\n";
            info += $"Pos : ({b.pos.X}, {b.pos.Y})\n";
            info += $"Spec : {b.specific}";
            ifLabel.Text = info;
        }

        //블록
        public class Block
        {
            public Panel panel = new Panel();
            public Point pos;
            public Type type = Type.Air;
            public double density = -1;
            public Status status = Status.None;
            public double temperature = 20;
            public bool can_burn = false;
            public double life = 0;
            public int tick = 0;
            public bool ctrl_in=false;
            public double specific = 10;

            //참조
            public Block(int x, int y)
            {
                pos = new Point(x, y);
                panel.Size = new Size(10, 10);
                panel.Location = new Point(x * panel.Width, y * panel.Height);
                panel.BackColor = Color.FromArgb(0, 0, 0);
                panel.MouseDown += new MouseEventHandler(Panel_Click);
                panel.MouseUp += new MouseEventHandler(MouseUp);
                panel.MouseEnter += new EventHandler(Enter);
                panel.MouseLeave += new EventHandler(Leave);
            }

            //MouseEnter
            void Enter(object sender, EventArgs e)
            {
                if (panel.BorderStyle != BorderStyle.Fixed3D) {
                    panel.BorderStyle = BorderStyle.FixedSingle;
                }
                SelectPos = pos;
                setInfo();
            }

            //MouseLeave
            void Leave(object sender, EventArgs e)
            {
                if (panel.BorderStyle != BorderStyle.Fixed3D)
                {
                    panel.BorderStyle = BorderStyle.None;
                }
            }

            //MouseDown
            void Panel_Click(object sender, MouseEventArgs e)
            {
                if (e.Button == MouseButtons.XButton1)
                {
                    pos1 = pos;
                    panel.BorderStyle = BorderStyle.Fixed3D;
                }
                else if (e.Button == MouseButtons.XButton2)
                {
                    Fill(pos1, pos);
                    
                }
                else if (e.Button == MouseButtons.Left)
                {
                    if (type == Type.Air)
                    {
                        setType(now);
                    }
                }
                else if (e.Button == MouseButtons.Right)
                {
                    setType(Type.Air);
                }
            }

            //MouseUP
            void MouseUp(object sender, MouseEventArgs e)
            {
            }

            //타입 설정
            public void setType(Type t)
            {
                Color c = Color.FromArgb(60, 60, 60);
                temperature = 20;
                tick = 0;
                life = 0;
                type = t;
                density = -1;
                can_burn = false;

                switch (t)
                {
                    case Type.Air:
                        c = Color.FromArgb(0, 0, 0);
                        status = Status.None;
                        specific = 10;
                        break;
                    case Type.Glass:
                        c = Color.FromArgb(80, 80, 80);
                        status = Status.Solid;
                        specific = 12;
                        break;
                    case Type.Sand:
                        density = 3.7;
                        status = Status.Dust;
                        c = Color.FromArgb(226,200,149);
                        specific = 19;
                        break;
                    case Type.Water:
                        density = 1;
                        status = Status.Liquid;
                        c = Color.FromArgb(100, 125, 255);
                        specific = 100;
                        break;
                    case Type.Oil:
                        can_burn = true;
                        density = 0.79;
                        status = Status.Liquid;
                        c = Color.FromArgb(78, 70, 35);
                        specific = 73;
                        break;
                    case Type.Fire:
                        life = 1.5;
                        temperature = 600;
                        density = -1;
                        status = Status.Energy;
                        c = Color.FromArgb(255, 98, 0);
                        specific = 200;
                        break;
                    case Type.Ice:
                        life = 1.5;
                        temperature = -10;
                        density = -1;
                        status = Status.Solid;
                        c = Color.FromArgb(168, 239, 255);
                        specific = 100;
                        break;
                }

                panel.BackColor = c;
            }
        }

        public Pixels()
        {
            InitializeComponent();
        }

        //로드
        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Load", "Start loading");
            ifLabel = InfoLabel;
            loadP.Size = Size;
            loadP.Location = new Point(0, 0);
            Label l = new Label();
            l.Location = new Point((int)(loadP.Width / 2)-50, (int)(loadP.Height / 2));
            l.Size = Size;
            l.Text = "Loading...";
            loadP.Visible = true;
            loadP.Controls.Add(l);

            //픽셀 설정
            for (int i = 0; i < FrameSize; i++)
            {
                for (int j = 0; j < FrameSize; j++)
                {
                    frame[i, j] = new Block(j, i);
                    frame[i, j].setType(Type.Air);
                    World.Controls.Add(frame[i, j].panel);
                }
            }
            l.Text = "Start";
            loadP.Visible = false;
            timer1.Start();
            timer2.Start();
            Log("Load", "Finish loading");
        }

        //[X] 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Form 움직이기
        Point clicked_pos;
        bool clicked_is = false;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked_is = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked_is == true)
            {
                SetDesktopLocation(MousePosition.X - clicked_pos.X, MousePosition.Y - clicked_pos.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked_is = true;
            clicked_pos = new Point(e.X, e.Y);
        }

        

        //Burn
        public void Burn(int x, int y)
        {
            if (x<FrameSize && x>=0 && y < FrameSize && y >= 0)
            {
                if (frame[y, x].can_burn == true)
                {
                    frame[y, x].setType(Type.Fire);
                }
            }
        }

        //열평형 함수
        public static void Thermal(int x, int y, int dx, int dy)
        {
            float value = 10;
            try
            {
                if (absolute(frame[y, x].temperature - frame[y + dy, x + dx].temperature) < 0.75)
                {
                    if (frame[y, x].temperature - frame[y + dy, x + dx].temperature < 0)
                    {
                        frame[y, x].temperature = frame[y, x].temperature + absolute(frame[y, x].temperature - frame[y + dy, x + dx].temperature) / 2;
                        frame[y + dy, x + dx].temperature = frame[y, x].temperature;
                    }
                    else if (frame[y, x].temperature - frame[y + dy, x + dx].temperature > 0)
                    {
                        frame[y + dy, x + dx].temperature = frame[y + dy, x + dx].temperature + absolute(frame[y, x].temperature - frame[y + dy, x + dx].temperature) / 2;
                        frame[y, x].temperature = frame[y + dy, x + dx].temperature;
                    }
                }
                else
                {
                    if (frame[y, x].temperature > frame[y + dy, x + dx].temperature)
                    {
                        frame[y, x].temperature -= value / frame[y, x].specific;
                        frame[y + dy, x + dx].temperature += value / frame[y + dy, x + dx].specific;
                    }
                    else if (frame[y, x].temperature < frame[y + dy, x + dx].temperature)
                    {
                        frame[y, x].temperature += value / frame[y, x].specific;
                        frame[y + dy, x + dx].temperature -= value / frame[y + dy, x + dx].specific;
                    }
                }
            }
            catch (Exception){ }
        }

        //물리 엔진 - 연산 및 실행 [주기 : 1밀리초]
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<int> l = new List<int>();
            List<int> liq = new List<int>();

            for (int i = 0; i < FrameSize; i++)
            {
                for (int j = 0; j < FrameSize; j++)
                {

                    int under = (int)(i + Gravity);

                    //압력

                    //물 - 녹는점/어는점
                    if (frame[i, j].temperature < 0 && frame[i, j].type == Type.Water)
                    {
                        double temple = frame[i, j].temperature;
                        frame[i, j].setType(Type.Ice);
                        frame[i, j].temperature = temple;
                    }
                    if (frame[i, j].temperature >= 0 && frame[i, j].type == Type.Ice)
                    {
                        double temple = frame[i, j].temperature;
                        frame[i, j].setType(Type.Water);
                        frame[i, j].temperature = temple;
                    }

                    //밀도
                    try
                    {
                        if (frame[i, j].density > frame[under, j].density && frame[i, j].density != -1 && frame[under, j].density != -1)
                        {
                            Type ex = frame[under, j].type;
                            frame[under, j].setType(frame[i, j].type);
                            frame[i, j].setType(ex);
                        }
                    } 
                    catch (Exception) { }

                    //중력
                    try
                    {
                        if ((frame[i, j].status == Status.Dust || frame[i, j].status == Status.Liquid) && frame[under, j].type == Type.Air)
                        {
                            bool no = true;
                            for (int m = 0; m < l.Count; m++)
                            {
                                if (l[m] == i)
                                {
                                    no = false;
                                    break;
                                }
                            }
                            if (no == true)
                            {
                                Type ex = frame[i, j].type;
                                frame[i, j].setType(Type.Air);
                                l.Add((int)(i + Gravity));

                                if (under < FrameSize)
                                {
                                    frame[under, j].setType(ex);
                                }
                            }
                            break;
                        }
                    }
                    catch (Exception) { }

                    //life 차감
                    if (frame[i, j].life > 0)
                    {
                        frame[i, j].life -= 0.01;
                        try
                        {
                            if (frame[i, j].type == Type.Fire && frame[i - 1, j].type == Type.Air && i - 1 >= 0 && frame[i, j].life < 1 && frame[i, j].life > 0.7)
                            {
                                frame[i - 1, j].setType(Type.Fire);
                                frame[i - 1, j].life = frame[i, j].life - 0.2;
                            }
                        }
                        catch (Exception) { }
                    }

                    //불
                    try
                    {
                        if (frame[i, j].type == Type.Fire)
                        {
                            Burn(j-1, i);
                            Burn(j+1, i);
                            Burn(j, i-1);
                            Burn(j, i+1);
                            frame[i, j].tick++;
                            if (frame[i, j].tick >= 80)
                            {
                                if (i - 1 >= 0 && frame[i - 1, j].type == Type.Air)
                                {
                                    frame[i - 1, j].setType(Type.Fire);
                                    frame[i - 1, j].life = frame[i, j].life;
                                }
                                frame[i, j].setType(Type.Air);
                            }
                            if (frame[i, j].life <= 0)
                            {
                                frame[i, j].setType(Type.Air);
                            }
                        }
                    }
                    catch (Exception){}

                }
            }
            setInfo();
        }

        //유체 역학 엔진
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < FrameSize; i++)
            {
                for (int j = 0; j < FrameSize; j++)
                {
                    List<int> liq = new List<int>();
                    int under = (int)(i + Gravity);

                    //물 - 불끄기
                    try
                    {
                        if (frame[i, j].type == Type.Water && frame[under, j].type == Type.Fire)
                        {
                            frame[under, j].setType(Type.Air);
                        }

                        Point add = new Point(1, 1);
                        switch (new Random().Next(0, 3))
                        {
                            case 1:
                                add = new Point(-1, 0);
                                break;
                            case 2:
                                add = new Point(0, -1);
                                break;
                            case 3:
                                add = new Point(1, 0);
                                break;
                        }

                        if (frame[i, j].type == Type.Water && frame[i + add.X, j + add.Y].type == Type.Fire)
                        {
                            frame[i + add.X, j + add.Y].setType(Type.Air);
                        }
                    }
                    catch (Exception) { }

                    //액체
                    try
                    {
                        if (frame[i, j].status == Status.Liquid && under >= FrameSize)
                        {
                            bool no = true;
                            for (int m = 0; m < liq.Count; m++)
                            {
                                if (liq[m] == i)
                                {
                                    no = false;
                                    break;
                                }
                            }
                            if (no == true)
                            {
                                int value = 1;
                                if (new Random().Next(0, 2) == 1)
                                {
                                    value = -1;
                                }
                                //ERRROR
                                if (frame[i, j + value].type == Type.Air || (frame[i, j + value].density < frame[i, j].density && frame[i, j + value].status == Status.Liquid))
                                {
                                    Type ex = frame[i, j + value].type;
                                    liq.Add(i + value);
                                    frame[i, j + value].setType(frame[i, j].type);
                                    frame[i, j].setType(ex);
                                }
                            }
                        }
                        if (frame[i, j].status == Status.Liquid && frame[under, j].type != Type.Air)
                        {
                            bool no = true;
                            for (int m = 0; m < liq.Count; m++)
                            {
                                if (liq[m] == i)
                                {
                                    no = false;
                                    break;
                                }
                            }
                            if (no == true)
                            {
                                int value = 1;
                                if (new Random().Next(0, 2) == 1)
                                {
                                    value = -1;
                                }
                                if (frame[i, j + value].type == Type.Air || (frame[i, j + value].density < frame[i, j].density && frame[i, j + value].status == Status.Liquid))
                                {
                                    Type ex = frame[i, j + value].type;
                                    liq.Add(i + value);
                                    frame[i, j + value].setType(frame[i, j].type);
                                    frame[i, j].setType(ex);
                                }
                            }
                        }
                    }
                    catch (AccessViolationException err) { Log("Error Liq", err); }
                }
            }
        }

        public void SelectType(Type type)
        {
            now = type;
            Log("SelectType", $"{type}");
            SelectL.Text = "Select : " + type;
        }

        //Glass
        private void button2_Click(object sender, EventArgs e)
        {
            SelectType(Type.Glass);
        }

        //Sand
        private void button3_Click(object sender, EventArgs e)
        {
            SelectType(Type.Sand);
        }
        //Air
        private void button3_Click_1(object sender, EventArgs e)
        {
            SelectType(Type.Air);
        }

        //Water
        private void button5_Click(object sender, EventArgs e)
        {
            SelectType(Type.Water);
        }

        //Oil
        private void button6_Click(object sender, EventArgs e)
        {
            SelectType(Type.Oil);
        }

        //Fire
        private void button7_Click(object sender, EventArgs e)
        {
            SelectType(Type.Fire);
        }
        
        //Ice
        private void Select7_Click(object sender, EventArgs e)
        {
            SelectType(Type.Ice);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static bool is_ctrl = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                is_ctrl = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                is_ctrl = false;
            }
        }

        private void button7_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        
    }
}