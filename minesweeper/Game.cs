using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Game : Form
    {
        Point coord;

        Button[,] btn = new Button[41, 41];
        int[,] btn_prop = new int[41, 41];
        int[,] saved_btn_prop = new int[41, 41];

        bool firstPlay = true;
        bool gameover = false;

        int seconds, minutes = 0;

        int[] dx8 = { 1, 0, -1, 0, 1, -1, -1, 1 };
        int[] dy8 = { 0, 1, 0, -1, 1, -1, 1, -1 };

        int start_x, start_y;
        int height, width, area;

        int mines, flags;
        int flag_value = 10;

        int btnSize = 20;
        int distanceBtwn = 20;

        private void gameLoad(object sender, EventArgs e)
        {

        }

        public Game()
        {
            InitializeComponent();
        }

        void setButtonImage(int x, int y)
        {
            btn[x, y].Enabled = false;
            btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;

            if (gameover == true && btn_prop[x, y] == flag_value)
                btn_prop[x, y] = saved_btn_prop[x, y];

            if (gameover == true)
                timer.Stop();

            switch (btn_prop[x, y])
            {
                case -1:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.bmb;
                    if (!gameover)
                        GameOver();
                    break;

                case 0:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.blank;
                    EmptySpace(x, y);
                    break;

                case 1:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._1;
                    break;

                case 2:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._2;
                    break;

                case 3:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._3;
                    break;

                case 4:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._4;
                    break;

                case 5:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._5;
                    break;

                case 6:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._6;
                    break;

                case 7:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._7;
                    break;

                case 8:
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources._8;
                    break;
            }

        }
        

        void EmptySpace(int x, int y)
        {
            if (btn_prop[x, y] == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    int x2 = x + dx8[i];
                    int y2 = y + dy8[i];

                    if (PointExists(x2, y2))
                        if (btn[x2, y2].Enabled == true && btn_prop[x2, y2] != -1 && !gameover)
                        {
                            gameProgress.Value++;
                            score.Text = "Score: " + gameProgress.Value.ToString();
                            setButtonImage(x2, y2);
                        }
                }
            }
        }

        bool PointExists(int x, int y)
        {
            if (x >= 1 && x <= width && y >= 1 && y <= height)
                return true;
            return false;
        }

        void RevealGrid()
        {
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn[i, j].Enabled == true)
                    {
                        setButtonImage(i, j);
                    }
        }

        void GameOver()
        {
            gameover = true;

            int saved = int.Parse(highS.Text);
            if (gameProgress.Value > saved)
            {
                highS.Text = gameProgress.Value.ToString();
                Properties.Settings.Default.highScore = highS.Text;
                Properties.Settings.Default.Save();
            }

            RevealGrid();
            MessageBox.Show("Game Over!");
        }

        void Check_FlagWin()
        {
            bool win = true;

            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn_prop[i, j] == -1)
                        win = false;

            if (win)
            {
                score.Text = "Score: " + area.ToString();
                WinGame();
            }
        }


        void WinGame()
        {
            gameover = true;
            
            int saved = int.Parse(highS.Text);
            if (gameProgress.Value > saved)
            {
                highS.Text = area.ToString(); 
                Properties.Settings.Default.highScore = highS.Text;
                Properties.Settings.Default.Save();
            }

            RevealGrid();
            gameProgress.Value = 0;
            MessageBox.Show("You win!");
        } 

        void Check_ClickWin()
        {
            bool win = true;
            for (int i = 1; i <= width; i++)
                for (int j = 1; j <= height; j++)
                    if (btn[i, j].Enabled == true && saved_btn_prop[i, j] != -1)
                        win = false;

            if (win)
            {
                score.Text = "Score: " + area.ToString();
                WinGame();
            }
        }

        private void OneClick(object sender, EventArgs e)
        {
            coord = ((Button)sender).Location;
            int x = (coord.X - start_x) / btnSize;
            int y = (coord.Y - start_y) / btnSize;

            if (btn_prop[x, y] != flag_value)
            {

                ((Button)sender).Enabled = false;
                ((Button)sender).Text = "";

                ((Button)sender).BackgroundImageLayout = ImageLayout.Stretch;

                if (btn_prop[x, y] != -1 && !gameover)
                {
                    gameProgress.Value++;
                    score.Text = "Score: " + gameProgress.Value.ToString();
                    Check_ClickWin();
                }

                setButtonImage(x, y);
            }
        }

        /*int MinesAround(int x, int y)
        {
            int score = 0;
            for (int i = 0; i < 8; i++)
            {
                int x2 = x + dx8[i];
                int y2 = y + dy8[i];

                if (PointExists(x2, y2) == true && btn_prop[x2, y2] == -1)
                    score++;
            }
            return score;
        }*/

        void SetMapNumbers(int x, int y)
        {
            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                    if (btn_prop[i, j] != -1)
                    {
                        int minesaround = 0;
                        for (int k = 0; k < 8; k++)
                        {
                            if (PointExists(i + dx8[k], j + dy8[k]) == true && btn_prop[i + dx8[k], j + dy8[k]] == -1)
                                minesaround++;
                        }
                        btn_prop[i, j] = minesaround;
                        saved_btn_prop[i, j] = minesaround;
                    }
        }

        private void RightClick(object sender, MouseEventArgs m)
        {

            if (m.Button == MouseButtons.Right)
            {

                coord = ((Button) sender).Location;
                int x = (coord.X - start_x) / btnSize;
                int y = (coord.Y - start_y) / btnSize;

                if (btn_prop[x, y] != flag_value && flags > 0)
                {
                    btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    btn[x, y].BackgroundImage = Minesweeper.Properties.Resources.flag;
                    btn_prop[x, y] = flag_value;
                    flags--;
                    Check_FlagWin();
                }
                else
                    if (btn_prop[x, y] == flag_value)
                    {
                        btn_prop[x, y] = saved_btn_prop[x, y];
                        btn[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                        btn[x, y].BackgroundImage = null;
                        flags++;
                    }

                remainingFlags.Text = "Flags: " + flags;
            }
        }

        void CreateButtons(int x, int y)
        {
            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(i * btnSize + start_x, j * btnSize + start_y, distanceBtwn, distanceBtwn);
                    btn[i, j].Click += new EventHandler(OneClick);
                    btn[i, j].MouseUp += new MouseEventHandler(RightClick);
                    btn_prop[i, j] = 0;
                    saved_btn_prop[i, j] = 0;
                    btn[i, j].TabStop = false;
                    Controls.Add(btn[i, j]);
                }
        }

        void SetMines(int x, int y, int mines)
        {
            Random rand = new Random();
            List<int> coordx = new List<int>();
            List<int> coordy = new List<int>();

            while (mines > 0)
            {
                coordx.Clear();
                coordy.Clear();

                for (int i = 1; i <= x; i++)
                    for (int j = 1; j <= y; j++)
                        if (btn_prop[i, j] != -1)
                        {
                            coordx.Add(i);
                            coordy.Add(j);
                        }

                int randNum = rand.Next(0, coordx.Count);
                btn_prop[coordx[randNum], coordy[randNum]] = -1;
                saved_btn_prop[coordx[randNum], coordy[randNum]] = -1;
                mines--;
            }
        }

        void StartGame()
        {
            mines = (int)(area * int.Parse(coef.Text) * 0.01);

            highS.Text = Properties.Settings.Default.highScore;

            flags = mines;
            gameover = false;

            gameProgress.Value = 0;
            gameProgress.Maximum = area - mines;

            timer.Start();
            seconds = 0;
            minutes = 0;

            remainingFlags.Text = "Flags: " + flags;
            score.Text = "Score: " + 0;

            if (firstPlay)
                CreateButtons(width, height);

            SetMines(width, height, mines);
            SetMapNumbers(width, height);
        }

        void ResetGame(int x, int y)
        {
            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                {
                    btn[i, j].Enabled = true;
                    btn[i, j].Text = "";
                    btn[i, j].BackgroundImage = null;
                    btn_prop[i, j] = 0;
                    saved_btn_prop[i, j] = 0;
                }
        }

        void Warnings(int id)
        {
            switch (id)
            {
                case 1:
                    MessageBox.Show("Empty fields!");
                    break;
                case 2:
                    MessageBox.Show("Invalid input!");
                    break;
                case 3:
                    MessageBox.Show("Input not in range!");
                    break;
            }
        }

        bool hasLetters(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (!Char.IsDigit(s, i))
                    return true;

            return false;
        }

        bool CorrectFields()
        {
            bool result = true;

            if (heightBox.Text == "" || widthBox.Text == "" || coef.Text == "")
            {
                Warnings(1);
                result = false;
            }
            else
            if (heightBox.Text != "" && widthBox.Text != "" && coef.Text != "")
            {
                if (hasLetters(heightBox.Text) || hasLetters(widthBox.Text) || hasLetters(coef.Text))
                {
                    Warnings(2);
                    result = false;
                }
                else if (int.Parse(coef.Text) > 100 || int.Parse(coef.Text) < 0)
                {
                    Warnings(3);
                    result = false;
                }
            }

            return result;
        }

        void SetDimensions()
        {
            height = int.Parse(heightBox.Text);
            width = int.Parse(widthBox.Text);

            if (height > 25)
                height = 25;
            else
                if (height < 5)
                height = 5;

            if (width > 40)
                width = 40;
            else
                if (width < 5)
                width = 5;

            heightBox.Text = height.ToString();
            widthBox.Text = width.ToString();

            area = height * width;

        }

        private void highScoreReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.highScore = "0";
            highS.Text = Properties.Settings.Default.highScore;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            
            if (CorrectFields())
            {
                SetDimensions();
                start_x = (this.Size.Width - (width + 2) * distanceBtwn) / 2;
                start_y = (this.Size.Height - (height + 2) * distanceBtwn) / 2;

                if (firstPlay)
                {
                    StartGame();
                    firstPlay = false;

                    widthBox.Enabled = false;
                    heightBox.Enabled = false;
                }
                else
                    if (!firstPlay)
                    {
                        ResetGame(width, height);
                        StartGame();
                    }
            }
        }

        private void timer_Tick(object sender, EventArgs m)
        {
            seconds++;

            switch (seconds)
            {
                case 60:
                    minutes++;
                    seconds = 0;
                    break;
            }

            secondsBox.Text = seconds.ToString();
            minutesBox.Text = minutes.ToString();
        }

    }
}
