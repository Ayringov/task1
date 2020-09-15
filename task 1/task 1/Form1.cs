using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Tile
        {
            protected int x;
            protected int y;
            enum TileType
            {
                Hero,
                Enemy,
                Gold,
                Weapon
            }
            abstract Tile(int xPos, int yPos)
            {
                x = xPos;
                y = yPos;

            }
            public class Obstacle : Tile
            {
                public Obstacle()
                    : this(xPos, yPos)
                {
                    
                }

            }
            

        }
        public class EmptyTile
        {
            public EmptyTile()
               
            {

            }
        }


        abstract class Character : Tile
        {
            protected int hP;
            protected int maxHp;
            protected int damage;

            public enum Movement
            {
                NoMovement,
                Up,
                Down,
                Left,
                Right
            }

            static void isDead()
            {
                if hP = 0;
                lblOne.Text = "you are dead";
            }

        }
        abstract class Enemy : Character
        {

        }
        
    }
}
