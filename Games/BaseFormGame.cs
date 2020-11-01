using System.Windows.Forms;

namespace Games
{
    public abstract class BaseFormGame : BaseForm
    {

        public BaseFormGame()
        {
            BaseSettings();
        }

        void BaseSettings() 
        {
            System.Drawing.Size size = new System.Drawing.Size(1150, 625);
            this.MaximumSize = size;
            this.MinimumSize = size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Start new game
        /// </summary>
        public abstract void StartGame();
    }

}
