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
    public partial class Form1 : Form
    {
        int count, expect, num;
        Stack<int> stack;

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            Random rnd = new Random();
            stack = new Stack<int>();
            count = 0;
            num = 0;
            expect = rnd.Next(30, 99);

            UpdateCount();
            UpdateNumber();
            UpdateExcept();
            
            

        }

        private void UpdateNumber() => numberView.Text = $"{num}";
        private void UpdateCount() => countView.Text = $"{count}";
        private void UpdateExcept() => expectView.Text = $"{expect}";

        private void CheckEndGame()
        {
            if (num == expect)
            {
                if (MessageBox.Show(this, "You WIN\n Start new game?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StartGame();
                }
                else
                {
                    Close();
                }
            }
        }

        private void Turn()
        {
            count += 1;

            UpdateNumber();
            UpdateCount();

            CheckEndGame();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stack.Push(num);

            num += 1;

            Turn();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            stack.Push(num);

            num *= 2;

            Turn();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (stack.Count != 0)
            {
                num = stack.Pop();

                Turn();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
