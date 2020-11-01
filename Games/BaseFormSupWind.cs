using System.Windows.Forms;

namespace Games
{
    public abstract class BaseFormSupWind : BaseForm
    {
        public BaseFormSupWind()
        {
            BaseSettings();
        }

        void BaseSettings()
        {
            System.Drawing.Size size = new System.Drawing.Size(300, 153);
            this.MaximumSize = size;
            this.MinimumSize = size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected void End()
        {
            this.Visible = false;
            this.Close();
        }
    }
}
