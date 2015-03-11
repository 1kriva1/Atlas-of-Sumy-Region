using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arcanoid
{
    public partial class Form1 : Form
    {
        int ball_sx=3, ball_sy=5;// transportation ball in x and y direction
        int rocket_speed = 14;
        int bricks = 7;        
        int super_bricks = 2;
        int life = 5;
        int level = 1;
        int z;
        int bonus=0;
        Random rand = new Random();
        
        public Form1()
        {
            InitializeComponent();
            label_life.Text = life.ToString();
            label_level.Text = level.ToString(); 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                shift_left();
            if (e.KeyCode == Keys.Right)
                shift_right();
            if (e.KeyCode == Keys.Space)
                timer.Enabled = true;            
        }

        public void shift_left()
        {
            if (rocket.Location.X > rocket_speed)
            {
                if (timer.Enabled == false)
                    ball.Location = new Point(rocket.Location.X+(rocket.Size.Width/2), rocket.Location.Y-ball.Size.Height);
                rocket.Location = new Point(rocket.Location.X - rocket_speed, rocket.Location.Y);
            }
            else
                rocket.Location = new Point(0, rocket.Location.Y);
        }

        public void shift_right()
        {
            if (rocket.Location.X + rocket.Size.Width < panel1.Width - rocket_speed)
            {
                    if (timer.Enabled == false)
                        ball.Location = new Point(rocket.Location.X + (rocket.Size.Width / 2), rocket.Location.Y - ball.Size.Height);
                rocket.Location = new Point(rocket.Location.X + rocket_speed, rocket.Location.Y);
            }
            else
                rocket.Location = new Point(panel1.Width - rocket.Size.Width, rocket.Location.Y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            shift_ball();
        }

        private void shift_ball()
        {            
            int x, y; // where ball must fly
            x = ball.Location.X + ball_sx;
            y = ball.Location.Y + ball_sy;
            if (x <= 0 || x >= panel1.Width - ball.Size.Width)
                { ball_sx = -ball_sx; return;}
            if (y <= 0) { ball_sy = -ball_sy; return;}
            if (y >= rocket.Location.Y - ball.Size.Height)
            {
                int bx1, bx2; // coordinates left and right side of ball
                int rx1, rx2, rx3, rx4, rx5; //coordinates  left and right side of platform

                bx1 = ball.Location.X;
                bx2 = ball.Location.X + ball.Size.Width;

                rx1 = rocket.Location.X;
                rx2 = rocket.Location.X + rocket.Size.Width;
                rx3 = rocket.Location.X + ((rocket.Size.Width)/2);
                rx4= rocket.Location.X+((rocket.Size.Width)/4);
                rx5 = rocket.Location.X + ((rocket.Size.Width) / 2) + ((rocket.Size.Width) / 4);

                if (bx2 > rx1 && bx1 < rx4)
                {
                    ball_sx = 3; ball_sy = 5;
                    if (ball_sx > 0)
                        ball_sx = -(ball_sx+2);
                    else
                        ball_sx = ball_sx+1;
                    ball_sy = -(ball_sy-2);
                    x = ball.Location.X + ball_sx;
                    y = ball.Location.Y + ball_sy;                    
                    return;
                }

                if(bx2>rx4 && bx1<rx3)
                {
                    ball_sx = 3; ball_sy = 5;
                    if (ball_sx > 0)
                        ball_sx = -ball_sx;
                    else
                        ball_sx = ball_sx;
                    ball_sy=-ball_sy;
                    x = ball.Location.X + ball_sx;
                    y = ball.Location.Y + ball_sy;
                    return;
                }

                if (bx2 > rx3 && bx1 < rx5)
                {
                    ball_sx = 3; ball_sy = 5;
                    if (ball_sx < 0)
                        ball_sx = -ball_sx;
                    else
                        ball_sx = ball_sx;
                    ball_sy = -ball_sy;
                    x = ball.Location.X + ball_sx;
                    y = ball.Location.Y + ball_sy;
                    return;
                }
                
                if(bx2>rx3 && bx1<rx2)
                {
                    ball_sx = 3; ball_sy = 5;
                    if (ball_sx < 0)
                        ball_sx = -(ball_sx+2);
                    else
                        ball_sx = ball_sx+1;
                    ball_sy =-(ball_sy-2);
                    x = ball.Location.X + ball_sx;
                    y = ball.Location.Y + ball_sy;  
                    
                    return;
                } 
                    
               
                else if(ball.Location.Y>=panel1.Size.Height-ball.Size.Height)
                    game_over();
                
            }

            hit_break(label1);
            hit_break(label2);
            hit_break(label3);
            hit_break(label4);
            hit_break(label5);
            hit_break(label6);
            hit_break(label7);
            hit_superbreak(label_super1);
            hit_superbreak(label_super2);
            hit_bonusbreak(super);
            ball.Location = new Point(x, y);
            if(timer.Enabled==false)
                ball.Location = new Point(rocket.Location.X + rocket.Size.Width / 2, rocket.Location.Y - ball.Size.Height);
        }

        private void game_over()
        {
            ball_sx = 3; ball_sy = 5;
            life--;
            label_life.Text = life.ToString();
            if (life <= 0)
            {
                timer.Enabled = false;
                MessageBox.Show("В тебе закінчились життя. Це все...", "Програли!");
                Close();
            }
            ball.Location = new Point(rocket.Location.X + rocket.Size.Width / 2, rocket.Location.Y - ball.Size.Height);
            timer.Enabled = false;
            MessageBox.Show("Ти впустив шарик!", "Програли!");
            rocket.Size = new System.Drawing.Size(114, 28);
            timer_bonus.Enabled = false;
            super.Visible = false;
        }

        private void game_win()
        {            
            level++;
            label_level.Text = level.ToString();
            ball_sx += 100;
            ball_sy += 100;
            timer.Enabled = false;
            MessageBox.Show("Всі камінці збиті!", "Перемога!");
            ball.Location = new Point(rocket.Location.X + rocket.Size.Width / 2, rocket.Location.Y - ball.Size.Height);
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label_super1.Visible = false;
            label_super2.Visible = false;
            bricks = 7;
            super_bricks = 2;
            rocket.Size = new System.Drawing.Size(114, 28);
            timer_bonus.Enabled = false;
            super.Visible = false;
        }

        private bool hit_break(Label brick)
        {
            int bx1, bx2;
            int by1, by2;
            int lx1, lx2;
            int ly1, ly2;
            if (brick.Visible == false)
                return false;
            bx1 = ball.Location.X;
            bx2 = ball.Location.X + ball.Size.Width;
            by1=ball.Location.Y;
            by2=ball.Location.Y+ball.Size.Height;
            lx1=brick.Location.X;
            lx2=brick.Location.X+brick.Size.Width;
            ly1=brick.Location.Y;
            ly2=brick.Location.Y+brick.Size.Height;
            if (bx2 >= lx1 && bx1 <= lx2 && by2 >= ly1 && by1 <= ly2)
            {
                brick.Visible = false;
                ball_sx = -ball_sx;
                ball_sy = -ball_sy;
                bricks--;
                z = rand.Next(0, 3);
                if (z == 1)
                {
                    super.Location = new Point(panel1.Location.X, panel1.Location.Y);
                    super.Visible = true;
                    timer_bonus.Enabled = true;
                }
                if (bricks <= 0)
                {
                    label_super1.Visible = true;
                    label_super2.Visible = true;
                }                 
                return true;
            }
            else return false;
        } 
       
        private bool hit_superbreak(Label brick)
        {
            int z;        
            int bx1, bx2;
            int by1, by2;
            int lx1, lx2;
            int ly1, ly2;
            if (brick.Visible == false)
                return false;
            bx1 = ball.Location.X;
            bx2 = ball.Location.X + ball.Size.Width;
            by1=ball.Location.Y;
            by2=ball.Location.Y+ball.Size.Height;
            lx1=brick.Location.X;
            lx2=brick.Location.X+brick.Size.Width;
            ly1=brick.Location.Y;
            ly2=brick.Location.Y+brick.Size.Height;
            if (bx2 >= lx1 && bx1 <= lx2 && by2 >= ly1 && by1 <= ly2)
            {          
                ball_sx = -ball_sx;
                ball_sy = -ball_sy;
                brick.Visible = false;                             
                super_bricks--;
                z = rand.Next(0, 3);
                if (z == 2)
                {
                    super.Location = new Point(panel1.Location.X, panel1.Location.Y); 
                    super.Visible = true;                     
                    timer_bonus.Enabled = true;
                }
                if (super_bricks <= 0)
                {
                    
                    game_win();
                }
                return true;
            }
            else return false;
        }

        private bool hit_bonusbreak(Label brick)
        {
            int bx1, bx2;
            int by1, by2;
            int lx1, lx2;
            int ly1, ly2;
            if (brick.Visible == false)
                return false;
            bx1 = ball.Location.X;
            bx2 = ball.Location.X + ball.Size.Width;
            by1 = ball.Location.Y;
            by2 = ball.Location.Y + ball.Size.Height;
            lx1 = brick.Location.X;
            lx2 = brick.Location.X + brick.Size.Width;
            ly1 = brick.Location.Y;
            ly2 = brick.Location.Y + brick.Size.Height;
            if (bx2 >= lx1 && bx1 <= lx2 && by2 >= ly1 && by1 <= ly2)
            {             
                super.Visible = false;
                bonus++;
                if(bonus==1)
                rocket.Size = new System.Drawing.Size(150, 28);
                else if (bonus == 2)
                    rocket.Size = new System.Drawing.Size(160, 28);
                else if (bonus == 3)
                    rocket.Size = new System.Drawing.Size(170, 28);
                else if (bonus == 4)
                    rocket.Size = new System.Drawing.Size(190, 28);
                timer_bonus.Enabled = false;               
                return true;
            }
            else return false;
        }

        private void shift_bonus()
        {
            int x, y;
            x = super.Location.X;
            y = super.Location.Y + 2;
            super.Location = new Point(x, y);
        }

        private void timer_bonus_Tick(object sender, EventArgs e)
        {
            shift_bonus();            
        } 
    }
}
