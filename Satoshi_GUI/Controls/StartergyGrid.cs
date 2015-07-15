using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satoshi_GUI.Controls
{
    
    public partial class StartergyGrid : UserControl
    {
        private int dist = 46;
        private int startwallDist = 3;
        public StratergySquare[] Squares;
        public StartergyGrid()
        {
            InitializeComponent();
        }

        private void StartergyGrid_Load(object sender, EventArgs e)
        {
            Squares = new StratergySquare[25];
            int index = 0;
            for (int Row = 0; Row < 5; Row++)
            {
                for (int Col = 0; Col < 5; Col++)
                {
                    Squares[index] =
                        new StratergySquare(this, new Point(((dist) * Col) + startwallDist, dist * Row + startwallDist));
                    index++;
                }
            }
        }
    }

    public class StratergySquare
    {
        private Panel _pObj;
        public int DrawNum { get; set; }
        public bool IsGlowing { get; private set; }
        public StratergySquare(Control parent, Point location)
        {
            DrawNum = 0;
            _pObj = new Panel();
            _pObj.Size = new Size(40, 40);
            _pObj.BackColor = Color.Gray;
            _pObj.Parent = parent;
            _pObj.Location = location;
            _pObj.AutoSize = true;
            _pObj.Show();
            _pObj.Click += _pObj_Click;

            IsGlowing = false;
        }

        void _pObj_Click(object sender, EventArgs e)
        {
            if (IsGlowing)
                Dim();
            else
                Glow();
        }

        public void Glow()
        {
            IsGlowing = true;
            _pObj.BackColor = Color.Green;
        }

        public void Dim()
        {
            IsGlowing = false;
            _pObj.BackColor = Color.Gray;
        }

        public void Bomb()
        {
            IsGlowing = true;
            _pObj.BackColor = Color.Red;
        }
    }
}
