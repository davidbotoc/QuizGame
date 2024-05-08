using System;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        //timer
        static int seconds = 0;


        public Form1()
        {
            InitializeComponent();
            LevelNumber.Text = Form2.chosenLevel;

            askQuestion(questionNumber);

            if (LevelNumber.Text == "LevelOne")
            {
                totalQuestions = 2;
                seconds = 5;
                timer1.Start();
            }
            else if (LevelNumber.Text == "LevelTwo")
            {
                totalQuestions = 3;
                seconds = 30;
                timer1.Start();
            }
            else if (LevelNumber.Text == "LevelThree")
            {
                totalQuestions = 4;
                seconds = 45;
                timer1.Start();
            }
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (seconds > 0 && questionNumber == totalQuestions)
            {
                timer1.Stop();
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show("Quiz Ended!" + Environment.NewLine +
                                "Time left: " + seconds + " seconds." + Environment.NewLine +
                                "You have answered " + score + " questions correctly." + Environment.NewLine +
                                "Your total percentage is " + percentage + "%" + Environment.NewLine +
                                "Click OK to play again!");

                score = 0;
                questionNumber = 0;



                askQuestion(questionNumber);

                this.Close();
            }

            questionNumber++;
            askQuestion(questionNumber);
        }


        //public static class LevelOneQuestions
        public static readonly string[,] LevelOneQuestions =
        {
            { "1 + 1 = ?", "1", "2", "3", "4", "2" },
            { "1 + 3 = ?", "1", "4", "7", "14", "2" },
            { "1 + 5 = ?", "2", "3", "6", "41", "3" },
            { "1 + 7 = ?", "2", "3", "9", "8", "4" }
        };

        public static string[,] Shuffle(Random random, string[,] arr)
        {
            int height = arr.GetUpperBound(0) + 1;
            int width = arr.GetUpperBound(1) + 1;

            for (int i = 0; i < height; ++i)
            {
                int randomRow = random.Next(i, height);
                for (int j = 0; j < width; ++j)
                {
                    string tmp = arr[i, j];
                    arr[i, j] = arr[randomRow, j];
                    arr[randomRow, j] = tmp;
                }
            }
            return arr;
        }

        static Random _random = new Random();
        string[,] shuffledQ = Shuffle(_random, LevelOneQuestions);

        private void askQuestion(int questionNumber)
        {
            if (LevelNumber.Text == "LevelOne")
            {
                switch (questionNumber)
                {

                    case 1:
                        Question.Text = shuffledQ[0, 0];
                        button1.Text = shuffledQ[0, 1];
                        button2.Text = shuffledQ[0, 2];
                        button3.Text = shuffledQ[0, 3];
                        button4.Text = (shuffledQ[0, 4]);

                        correctAnswer = Convert.ToInt32(shuffledQ[0, 5]);

                        break;
                    case 2:
                        Question.Text = "What iws the colour of the sky?";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 1;

                        break;
                    case 3:
                        Question.Text = "What is the colour of the sky?";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 1;

                        break;
                    case 4:
                        Question.Text = "What is the colour of the sky?";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 4;

                        break;

                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }
            else if (LevelNumber.Text == "LevelTwo")
            {
                switch (questionNumber)
                {

                    case 1:
                        Question.Text = "What is the colour of the sky? level two";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 2;

                        break;
                    case 2:
                        Question.Text = "What iws the colour of the sky? l2";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 3;

                        break;
                    case 3:
                        Question.Text = "What is the colour of the sky? l2";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 1;

                        break;
                    case 4:
                        Question.Text = "What is the colour of the sky? l2";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 4;

                        break;

                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }
            else if (LevelNumber.Text == "LevelThree")
            {
                switch (questionNumber)
                {

                    case 1:
                        Question.Text = "What is the colour of the sky? l3";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 2;

                        break;
                    case 2:
                        Question.Text = "What iws the colour of the sky? l3";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 3;

                        break;
                    case 3:
                        Question.Text = "What is the colour of the sky? l3";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 1;

                        break;
                    case 4:
                        Question.Text = "What is the colour of the sky? l3";
                        button1.Text = "Blue";
                        button2.Text = "Red";
                        button3.Text = "Yellow";
                        button4.Text = "OK";

                        correctAnswer = 4;

                        break;

                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = seconds--.ToString();
            if (seconds < 0)
            {
                timer1.Stop();

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show("Quiz Ended!" + Environment.NewLine +
                                "You have answered" + score + " questions correctly." + Environment.NewLine +
                                "Your total percentage is " + percentage + "%" + Environment.NewLine +
                                "Click OK to play again!");

                score = 0;
                questionNumber = 0;
                this.Close();
            }
            /*askQuestion(questionNumber);
            this.Close();*/
        }
    }
}
