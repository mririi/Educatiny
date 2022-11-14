using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educatiny
{
    public partial class Quiz : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Quiz()
        {
            InitializeComponent();
            askQuestion(questionNumber);

            totalQuestions = 8; 
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {

            var senderObject = (Button)sender;
            MessageBox.Show("hello");

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }

            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {

            switch (qnum)
            {
                case 1:

                    label1.Text = "What is the colour of the sky?";

                    button1.Text = "Blue";
                    button2.Text = "Yellow";
                    button3.Text = "Orange";
                    button4.Text = "Red";

                    correctAnswer = 1;

                    break;
                case 2:

                    label1.Text = "What is the name of the main character from Iron Man?";

                    button1.Text = "Tony Stank";
                    button2.Text = "Tony Stark";
                    button3.Text = "Rody";
                    button4.Text = "Peter Quill";

                    correctAnswer = 2;

                    break;
                case 3:

                    label1.Text = "What is the name of this game?";

                    button1.Text = "Call of Duty";
                    button2.Text = "Battlefield";
                    button3.Text = "Fortnite";
                    button4.Text = "CS - GO";

                    correctAnswer = 4;

                    break;
                case 4:

                    label1.Text = "Which Publisher made this game?";

                    button1.Text = "EA";
                    button2.Text = "Activision";
                    button3.Text = "Epic Games";
                    button4.Text = "Equare Enix";

                    correctAnswer = 3;

                    break;

                case 5:

                    label1.Text = "Whats the name of this game?";

                    button1.Text = "Gears of War";
                    button2.Text = "Assassins Creed";
                    button3.Text = "Uncharted";
                    button4.Text = "Call of Duty";

                    correctAnswer = 1;

                    break;

                case 6:

                    label1.Text = "What is the main characters name in the game above?";

                    button1.Text = "Drake";
                    button2.Text = "Lara Croft";
                    button3.Text = "Master Cheif";
                    button4.Text = "Markus";

                    correctAnswer = 3;

                    break;

                case 7:

                    label1.Text = "Who was Geralt looking for in Witcher 3?";

                    button1.Text = "Victoria";
                    button2.Text = "Mr Donut";
                    button3.Text = "Ciri";
                    button4.Text = "Yennifer";

                    correctAnswer = 3;

                    break;

                case 8:

                    label1.Text = "Which city is the captial city of England?";

                    button1.Text = "Birmingham";
                    button2.Text = "Brighton";
                    button3.Text = "Liverpool";
                    button4.Text = "London";

                    correctAnswer = 4;

                    break;




            }



        }
        int Y = 0;
        SqlConnection con = new SqlConnection("Data Source=WASSIM-PC\\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True");
        private void OnButtonClick(object sender, EventArgs e)
        {
            string matiere = ((Button)sender).Text;
            MessageBox.Show(matiere);
        }
        private void Quiz_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from [Matiere]", con);
            DataTable dtable = new DataTable();
            cmd.Fill(dtable);
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Text = dtable.Rows[i][1].ToString();
                btn.Name = dtable.Rows[i][1].ToString();
                btn.Click += new EventHandler(OnButtonClick);
                btn.Size = new Size(300, 100);
                if (i % 2 == 0)
                {
                    btn.Location = new Point(90, 100 * (Y + 1));
                }
                else
                {
                    btn.Location = new Point(450, 100 * Y);
                }
                Y++;
                Controls.Add(btn);
            }
        }
    }
}
