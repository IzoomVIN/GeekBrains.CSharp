using System.Windows.Forms;

namespace Games
{
    public partial class SayNumber : BaseFormSupWind
    {
        private GuessTheNumber parent;
        public SayNumber(GuessTheNumber parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(this.WriteBox.Text, out int x))
            {
                End();
                parent.Turn(x);
            }
        }

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            End();
        }
    }
}
