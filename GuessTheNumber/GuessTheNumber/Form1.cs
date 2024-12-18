using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace GuessTheNumber
{
    // Уровень сложности
    public enum Level {Easy = 20, Normal = 10, Hard = 8, Insane = 3};
    public partial class startForm : Form
    {
        List<Player> plrs = new List<Player>();
        public startForm()
        {
            InitializeComponent();
        }
        // Начинаем игру
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Проверка профиля
            if (methSignIn() == null)
                return;

            Player plr = methSignIn();

            // Определить число попыток            
            Level lvl = determineNumAttempts();            
            // Загадываем число 1 до 1000
            Random rnd = new Random();
            int hiddenNum = rnd.Next(1, 1000);

            gameForm gameForm = new gameForm(lvl, hiddenNum, plr);
            gameForm.ShowDialog(this);

            // Обовляем список лучших игроков
            methListBestPlrs();
            ToJson();
        }

        // Выбор уровня сложности
        private Level determineNumAttempts()
        {
            Level lvl;
            if (rBtnEasy.Checked) lvl = Level.Easy;
            else if (rBtnNormal.Checked) lvl = Level.Normal;
            else if (rBtnHard.Checked) lvl = Level.Hard;
            else lvl = Level.Insane;
            return lvl;
        }

        // Выход из игры
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Player plr = new Player();
            regForm regForm = new regForm(plr, plrs);
            regForm.ShowDialog(this);

            // Сохраняем профиль игрока в файле
            ToJson();
            methListBestPlrs();
        }
        // Войти в профиль
        private Player methSignIn()
        {
            // Находим пользователя по имени
            var plr = plrs.FirstOrDefault(u => u.Name == tbLogin.Text);
            // Проверяем, существует ли пользователь и совпадает ли пароль
            if (plr != null && plr.Password == tbPass.Text)
            {
                Console.WriteLine("Доступ разрешен");
                return plr;
            }
            else
            {
                Console.WriteLine("Неправильное имя пользователя или пароль");
                MessageBox.Show("Incorrect login or password" , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                return null;
            }
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            // При загрузки формы проверяется существует ли список игроков, если нет создаём пустой список
            InJson();            
            methListBestPlrs();    
        }

        // Метод выводит на экран список лучших игроков
        private void methListBestPlrs()
        {
            // Если список пустой выходим из метода
            if (plrs == null)
            {
                return;
            }
            plrs.Sort();
            StringBuilder sb = new StringBuilder();

            for (int k = 1; k <= plrs.Count; k++)
            {
                sb.Append(k + " : " + plrs[k - 1].ToString() + "\n");
            }
            rtbBestPlrs.Text = sb.ToString();
        }
        // Сереализуем список игроков в Json
        private void ToJson()
        {
            // Сериализуем список в JSON и сохраняем в текстовый файл
            string json = JsonConvert.SerializeObject(plrs, Formatting.Indented);
            // Сохраняем JSON в файл
            File.WriteAllText("plrs.json", json);

            Console.WriteLine("Список был успешно сериализован в файл 'plrs.json'.");
        }
        // Десериализуем текстовый файла, содержащий JSON-список
        private void InJson()
        {
            string filePath = "plrs.json";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "");
                return;
            }            
            string json = File.ReadAllText("plrs.json");
            if(json == "")
            {
                return;
            }
            // Десериализация JSON в список объектов Person
            plrs = JsonConvert.DeserializeObject<List<Player>>(json);
        }        
    }
}
