using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class MessageWindow : BaseFormSupWind
    {
        BaseFormGame parent;

        public MessageWindow(BaseFormGame parent, String status)
        {
            this.parent = parent;
            InitializeComponent();
            this.TextLabel.Text = $"You {status}\n Start new game?";
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            End();
            parent.StartGame();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            End();
            parent.Close();
        }
    }
}
