using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satoshi_GUI
{
    public partial class Satoshi_grid : UserControl
    {
        private int dist = 26;
        private int startwallDist = 3;
        public GridSquare[] Squares { get; private set; }

        private void Satoshi_grid_Load(object sender, EventArgs e)
        {

        }

        public Satoshi_grid()
        {
            InitializeComponent();
            Squares = new GridSquare[25];
            int index = 0;
            for (int Row = 0; Row < 5; Row++)
            {
                for (int Col = 0; Col < 5; Col++)
                {
                    Squares[index] =
                        new GridSquare(this, new Point(((dist) * Col) +startwallDist, dist * Row + startwallDist));
                    index++;
                }
            }
        }
        public void Reset()
        {
            foreach (GridSquare s in Squares)
                s.Dim();
        }

    }

    public class GridSquare
    {
        private Panel _pObj;
        public bool IsGlowing { get; private set; }
        public GridSquare(Control parent, Point location)
        {
            _pObj = new Panel();
            _pObj.Size = new Size(20, 20);
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
