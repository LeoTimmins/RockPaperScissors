namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        // define global variables 



        public static string ComputerChoice = "";

        public static long playerScr = 0;

        public static long computerScr = 0;

        public static int computerchoice = 0;

        int Money = 500;

        public static Random random = new Random();

        Image rock = Image.FromFile("C:/Users/Churc/source/repos/WinFormsApp2/WinFormsApp2/Img/GetImage.png");
        Image paper = Image.FromFile("C:/Users/Churc/source/repos/WinFormsApp2/WinFormsApp2/Img/GetImage(1).png");
        Image scissors = Image.FromFile("C:/Users/Churc/source/repos/WinFormsApp2/WinFormsApp2/Img/GetImage(2).png");



        // the function that handles main gameplay (not banking or upgrades) 

        int computerScore = 0;
        int playerScore = 0;

        public void gF_1(string Choice)

        {

            while (true) // very bad solution to prevent cchoice from returning 0 

            {

                computerchoice = random.Next(4);

                if (computerchoice != 0)

                {

                    break;

                }

            }



            // Hides objects to move to next menu 



            //lblChoice.Visible = false;

            //picRock.Visible = false;

            //picPaper.Visible = false;

            //picScissors3.Visible = false;



            // turns the random number into a choice for the computer 



            if (computerchoice == 1)

            {
                pbEnemy.Image = rock;
                ComputerChoice = "rock";

            }

            else if (computerchoice == 2)

            {
                pbEnemy.Image = paper;
                ComputerChoice = "paper";

            }

            else if (computerchoice == 3)

            {
                pbEnemy.Image = scissors;
                ComputerChoice = "scissors";

            }

            else

            {

                ComputerChoice = "";

            }


            string winner;

            if (Choice == "rock")
            {
                pbPlayer.Image = rock;
            }else if(Choice == "paper")
            {
                pbPlayer.Image = paper;
            }else if(Choice == "scissors")
            {
                pbPlayer.Image = scissors;
            }



            if (Choice == ComputerChoice)

            {

                winner = "draw";

            }

            else if (Choice == "rock" && ComputerChoice == "scissors")

            {

                winner = "player";

            }

            else if (Choice == "paper" && ComputerChoice == "rock")

            {

                winner = "player";

            }

            else if (Choice == "scissors" && ComputerChoice == "paper")

            {

                winner = "player";

            }

            else

            {

                winner = "computer";

            }



            if (winner == "draw")

            {
                lblWinLossDraw.Visible = true;
                lblWinLossDraw.ForeColor = Color.Yellow;
                lblWinLossDraw.Text = "You Drew";


            }

            else if (winner == "player")

            {
                lblWinLossDraw.Visible = true;
                lblWinLossDraw.ForeColor = Color.Lime;
                lblWinLossDraw.Text = "You Won";

                playerScore += 1;

            }
            else if (winner == "computer")

            {
                lblWinLossDraw.Visible = true;
                lblWinLossDraw.ForeColor = Color.Red;
                lblWinLossDraw.Text = "You Lost";

                computerScore += 1;

            }

            else

            {

                lblWinLossDraw.Text = "winner was " + winner;

            }



            //update score counter 

            lblScore.Text = "Player | "+playerScore+"\nAI NPC   | "+computerScore;





            //checks for winner 

            if (computerScore == 10)

            {
                lblWinLossDraw.Visible = false;
                lblWinLossDrawf.Visible = true;
                lblWinLossDrawf.ForeColor = Color.Red;
                lblWinLossDrawf.Text = "You lost the game!";
                button9.Visible = true;
                pbEnemy.Visible = false;
                pbPlayer.Visible = false;
                button7.Visible = false;
                button5.Visible = false;
                button8.Visible = false;
                lblMoney.Text = Money.ToString() + "$";
            }

            else if (playerScore == 10)
            {
                lblWinLossDraw.Visible = false;
                lblWinLossDrawf.Visible = true;
                lblWinLossDrawf.ForeColor = Color.Lime;
                lblWinLossDrawf.Text = "You won the game!";
                button9.Visible = true;
                pbPlayer.Visible = false;
                button7.Visible = false;
                button5.Visible = false;
                button8.Visible = false;

                Money += 100;
                lblMoney.Text = Money.ToString() + "$";
            }

            else

            {

                //btnReplayGame.Visible = true;

            }



            lblWinLossDraw.Visible = true;



        }



        public void Rock(object sender, EventArgs e)

        {

            string Choice = "rock";

            gF_1(Choice);

        }

        public void Paper(object sender, EventArgs e)

        {

            string Choice = "paper";

            gF_1(Choice);

        }

        public void Scissors(object sender, EventArgs e)

        {

            string Choice = "scissors";

            gF_1(Choice);

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 1486, 737
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 80, 250, 737));
            System.Drawing.SolidBrush myBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            formGraphics.FillRectangle(myBrush2, new Rectangle(0, 0, 1486, 80));
            formGraphics.FillRectangle(myBrush2, new Rectangle(0, 0, 10, 737));
            formGraphics.FillRectangle(myBrush2, new Rectangle(1476, 0, 1486, 737));
            formGraphics.FillRectangle(myBrush2, new Rectangle(0, 727, 1486, 737));
            System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
            System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            int radius = 30;
            int centerX = 1200;
            int centerY = 40;
            formGraphics.FillEllipse(myBrush3, centerX - radius, centerY - radius, radius + radius, radius + radius);
            centerX = 1300;
            formGraphics.FillEllipse(myBrush4, centerX - radius, centerY - radius, radius + radius, radius + radius);
            centerX = 1400;
            formGraphics.FillEllipse(myBrush5, centerX - radius, centerY - radius, radius + radius, radius + radius);
            myBrush.Dispose();
            formGraphics.Dispose();
        }


        int LastMousePosX;
        int LastMousePosY;
        int LastWinPosX;
        int LastWinPosY;

        int MouseDiffX, MouseDiffY;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            computerScore = 0;

            lblWinLossDraw.Visible = true;
            lblWinLossDrawf.Visible = false;
            button9.Visible = false;
            pbPlayer.Visible = true;
            pbEnemy.Visible = true;
            button7.Visible = true;
            button5.Visible = true;
            button8.Visible = true;
            lblWinLossDraw.Visible = false;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}