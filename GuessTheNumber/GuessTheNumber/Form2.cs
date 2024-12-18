using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class gameForm : Form
    {        
        private Level lvl; // Сложность (Число попыток)
        private int enterNum;   // Введённое число
        private int hiddenNum;  // Число - загадка 
        List<string> HistoryGame = new List<string> { };   // История игры
        Player plr;
        public gameForm()
        {
            InitializeComponent();
        }
        public gameForm(Level lvl, int hiddenNum, Player plr)
        {
            InitializeComponent();
            this.lvl = lvl;
            this.hiddenNum = hiddenNum;
            this.plr = plr;         
        }
        private void gameForm_Load(object sender, EventArgs e)
        {
            tbLastAttempts.Text = ((int)lvl).ToString();
            methScoring();
        }

        // Находим число
        private void btnGuess_Click(object sender, EventArgs e)
        {            
            methGame();
        }

        private void methGame()
        {
            // Вводим число и проверяем, что это число
            int tmp1;
            bool isValid = Int32.TryParse(tbNum.Text, out tmp1);
            if (isValid && tmp1 >= 0 && tmp1 <= 1000)
            {
                enterNum = tmp1;
            }
            else
            {
                MessageBox.Show("Invalid number or number out of range.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return;
            }

            if (hiddenNum == enterNum)
            {
                // Число угадано -> игра выиграна -> выход из игры 
                MessageBox.Show($"You guessed the number correctly.\nGreat job!!!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                plr.methBestRes();
                return;
            }
            else if (enterNum > hiddenNum)
            {                
                methListHint($"{enterNum}, need a smaller number");               
            }
            else
            {
                methListHint($"{enterNum}, need a larger number");                
            }
            // Отнимаем 100 очков за каждый проигранный раунд игры
            plr.Score -= 100;
            tbScore.Text = plr.Score.ToString();

            // Считаем сколько попыток осталось
            methLastAttempts();
        }

        private void methLastAttempts()
        {
            // Число не угадано, минус одна попытка
            lvl--;
            tbLastAttempts.Text = lvl.ToString();

            if (lvl == 0)
            {
                // Число попыток равно нулю -> игра проиграна -> выход из игры 
                plr.Score = 0;
                MessageBox.Show($"You have used all your attempts.\nThe number was: {hiddenNum}", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Записываем ходы в историю
        private void methListHint(string str)
        {           
            HistoryGame.Add(str + "\n");
            StringBuilder sb = new StringBuilder();
            
            for (int k  = 1; k <= HistoryGame.Count; k++)
            {
                sb.Append(k + " : " + HistoryGame[k - 1].ToString());
            }

            rtbHistoryGame.Text = sb.ToString();
        }

        // Определяем количество очков, получаемых при старте игры в зависимости от уровня сложности. 
        private void methScoring()
        {
            switch (lvl)
            {
                case Level.Easy:
                    plr.Score = 1000;
                    break;
                case Level.Normal:
                    plr.Score = 2000;
                    break;
                case Level.Hard:
                    plr.Score = 3000;
                    break;
                case Level.Insane:
                    plr.Score = 4000;
                    break;
            }
            tbScore.Text = plr.Score.ToString();        
        }

        // Подсказка отнимает 400 очков, её можно взять только один раз
        private void btnHint_Click(object sender, EventArgs e)
        {
            if (plr.Score - 400 > 0)
            {
                plr.Score -= 400;
                tbHint.Text = hiddenNum % 2 == 0 ? "The hidden number is divisible by two" : "The hidden number isn't divisible by two";
                btnHint.Text = "No more hints";
                btnHint.Enabled = false;
                tbScore.Text = plr.Score.ToString();
            }
            else
            {
                MessageBox.Show("Not enough points to take the hint", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
