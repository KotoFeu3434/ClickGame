using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ClickGame
{
    public partial class Form1 : Form
    {
        int counter = 0;      
        int timeLeft = 30;      
        int lastScore = 0;    
        int highScore = 0;      
        bool gameStarted = false;
        Timer countdownTimer;

        public Form1()
        {
            InitializeComponent();
            buttonClick.Click += buttonClick_Click;

            MessageBox.Show("Натисніть ПРОБІЛ, щоб почати гру!");

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;

        
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            
            if (File.Exists("LastScore.json"))
            {
                string json = File.ReadAllText("LastScore.json");
                lastScore = JsonSerializer.Deserialize<int>(json);
                labelLast.Text = $"Останній рахунок: {lastScore}";
            }

   
            if (File.Exists("HighScore.json"))
            {
                string json = File.ReadAllText("HighScore.json");
                highScore = JsonSerializer.Deserialize<int>(json);
                labelHigh.Text = $"Рекорд: {highScore}";
            }

           
            labelTime.Text = $"Час: {timeLeft}";
            labelScore.Text = $"Рахунок: {counter}";
        }
         
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

           

            if (e.KeyCode == Keys.Space && !gameStarted)
            {
                gameStarted = true;
                counter = 0;
                timeLeft = 30;

                labelTime.Text = $"Час: {timeLeft}";
                labelScore.Text = $"Рахунок: {counter}";

                countdownTimer.Start();
                MessageBox.Show("Гра почалася!");
            }
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                labelTime.Text = $"Час: {timeLeft}";
            }
            else
            {
                countdownTimer.Stop();
                gameStarted = false;

                lastScore = counter;
                labelLast.Text = $"Останній рахунок: {lastScore}";

         
                if (counter > highScore)
                {
                    highScore = counter;
                    labelHigh.Text = $"Рекорд: {highScore}";
                    File.WriteAllText("HighScore.json",
                        JsonSerializer.Serialize(highScore, new JsonSerializerOptions { WriteIndented = true }));
                    MessageBox.Show($"Новий рекорд! {highScore} ");
                }

         
                File.WriteAllText("LastScore.json",
                    JsonSerializer.Serialize(lastScore, new JsonSerializerOptions { WriteIndented = true }));

                MessageBox.Show($"Гру завершено! Ваш рахунок: {counter}");
            }
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                counter++;
                labelScore.Text = $"Рахунок: {counter}";
            }
            else
            {
                MessageBox.Show("Спочатку натисніть ПРОБІЛ, щоб почати гру!");
            }
        }
    }
}
