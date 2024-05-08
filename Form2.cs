using System;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form2 : Form
    {
        public static string chosenLevel;
        public Form2()
        {
            InitializeComponent();
        }

        private void LevelOne_Click(object sender, EventArgs e)
        {
            chosenLevel = LevelOne.Text;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void LevelTwo_Click(object sender, EventArgs e)
        {
            chosenLevel = LevelTwo.Text;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void LevelThree_Click(object sender, EventArgs e)
        {
            chosenLevel = LevelThree.Text;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
