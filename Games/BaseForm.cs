using System.Windows.Forms;

namespace Games
{
    
    public abstract class BaseForm : Form
    {
        
        public BaseForm()
        {
            BaseSettings();
        }

        void BaseSettings()
        {
            this.Font = new System.Drawing.Font("Ravie", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new Padding(6, 6, 6, 6);
        }

    }
}
