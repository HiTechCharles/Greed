using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Greed
{
    public partial class PlayerSettings : Form
    {
        public static string P1Type, P2Type, p1Name, p2Name;
        public static bool SpeechToggle;

        private void Name2_TextChanged(object sender, System.EventArgs e)
        {
            p2Name = Name2TB.Text;
        }

        private void PlayBTN_Click(object sender, System.EventArgs e)
        {
            if (Name1TB.Text.Length == 0)  //check for blank player names
            {
                p1Name = "Player 1";
            }

            if ( Name2TB.Text.Length == 0)
            {
                p2Name = "Player 2";
            }
            this.Hide();

            Form form2 = new GreedGame();  //show form2
            form2.ShowDialog(this);
        }

        private void SpeechCHK_CheckedChanged(object sender, System.EventArgs e)
        {
            if (SpeechCHK.Checked)
            {
                SpeechToggle = true;
            }
        }

        private void Name1TB_TextChanged(object sender, System.EventArgs e)
        {
            p1Name=Name1TB.Text;
        }

        public PlayerSettings()
            {
            InitializeComponent();
            PlayerTypeCB.SelectedIndex = 0;
    }

        private void PlayerTypeCB_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (PlayerTypeCB.SelectedIndex)
            { 
                case 0:
                    P1Type = "Human";
                    P2Type = "Computer";
                    break;
                case 1:
                    P1Type = "Human";
                    P2Type = "Human";
                    break;
            case 2:
                    P1Type = "Computer";
                    P2Type = "Computer";
                    break;
            }
        }
    }
}