using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoxAndHound.Classes.Implementations;

namespace FoxAndHounds
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Board board = new Board();
            board.Location = new Point(40, 15);
            this.Controls.Add(board);
        }
    }
}
