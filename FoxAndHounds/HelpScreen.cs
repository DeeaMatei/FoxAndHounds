using System.Windows.Forms;

namespace FoxAndHounds
{
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
            labelRulesText.Text = @"The four hounds are initially placed on the dark squares at one edge of the board; the fox is placed on any dark square on the opposite edge. The objective of the fox is to cross from one side of the board to the other, arriving at any one of the hounds' original squares; the hounds' objective is to prevent it from doing so.
The hounds move like a draughts man, diagonally forward one square. The fox moves like a draughts king, diagonally forward or backward one square. However, there is no jumping, promotion, or removal of pieces. The play alternates with the fox moving first. The player controlling the hounds may move only one of them each turn.
The fox is trapped when it can no longer move to a vacant square. It is possible for two hounds to trap the fox against an edge of the board (other than their original home-row) or even one corner (see diagram) where a single hound may do the trapping. Should a hound reach the fox's original home row it will be unable to move further.";
            labelVsComputerText.Text = @"The player will choose which pieces he wants to play with. During his turn, the player must select the piece he wants to move and then select a legal square where the piece will be moved. After his turn, the player must wait for the Computer to make a move.";
            labelPvpLocalText.Text = @"The first player will play with the Fox, and the other one with the Hounds. Each player will take a turn, selecting the piece he wants to move and then a legal square where the piece will be moved.";
            labelPvpLanText.Text = @"The players must connect to the server by entering the IP Address and the Port. During gameplay, each player will take a turn, selecting the piece he wants to move and then a legal square where the piece will be moved. After a move, a player must wait for the other player to make a move.";
        }
    }
}