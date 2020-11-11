using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkLast
{
    public partial class HW8 : Form
    {
        /// <summary>
        /// <para>2</para>
        /// <para>Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown</para>
        /// </summary>
        public HW8()
        {
            InitializeComponent();
            
        }

        private void UpdateTextEvent(object sender, EventArgs e)
        {
            textLab.Text = textBox.Text;
        }
        
        private void UpdateValueEvent(object sender, EventArgs e)
        {
            textBox.Text = numericUpDown1.Value.ToString();
        }
    }
}
