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
    public partial class stratergyDisplay : UserControl
    {
        private int dist = 11;
        private int startwallDist = 3;
        public StratergyDisplaySquare[] Squares;
        public stratergyDisplay()
        {
            InitializeComponent();
            Squares = new StratergyDisplaySquare[25];
            int index = 0;
            for (int Row = 0; Row < 5; Row++)
            {
                for (int Col = 0; Col < 5; Col++)
                {
                    Squares[index] =
                        new StratergyDisplaySquare(this, new Point(((dist) * Col) + startwallDist, dist * Row + startwallDist));
                    index++;
                }
            }
        }

        public void Reset()
        {
            foreach (StratergyDisplaySquare ss in Squares)
                ss.Dim();
        }

        private void stratergyDisplay_Load(object sender, EventArgs e)
        {

        }
    }

    public class StratergyDisplaySquare
    {
        private Panel _pObj;
        public bool IsGlowing { get; private set; }
        public StratergyDisplaySquare(Control parent, Point location)
        {
            _pObj = new Panel();
            _pObj.Size = new Size(9, 9);
            _pObj.BackColor = Color.Gray;
            _pObj.Parent = parent;
            _pObj.Location = location;
            _pObj.Show();

            IsGlowing = false;
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
