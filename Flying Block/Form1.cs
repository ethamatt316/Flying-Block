//January 2021
//Ethan Mattucci
//Flying Block
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flying_Block
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int score = 0;
        int pipespeed = 15;
      
        public Form1()
        {
            InitializeComponent();
            endText.Text = "Game Over!";
            endText.Visible = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = -10;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
            private void timer1_Tick(object sender, EventArgs e)
        {
            //Moves pipes and gives the block gravity
            flyingBlock.Top += gravity;
            pipeBottom.Left -= pipespeed;
            pipeTop.Left -= pipespeed;
            totalText.Text = "Score:" + score;
            //Moves the pipes to the left of the screen and brings them to the right, and gives player points
            if (pipeBottom.Left < -150)
            {  
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180) 

                pipeTop.Left = 950;
            
            //Provides collison to the objects, and ends the game when it it collides
            if (flyingBlock.Bounds.IntersectsWith(pipeBottom.Bounds) ||                
                flyingBlock.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flyingBlock.Bounds.IntersectsWith(bottomCollison.Bounds) )               
            {
                gametimer.Enabled = false;
            }
               Refresh();
                              
        }
    }
}          
