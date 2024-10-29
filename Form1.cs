using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdStart
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;
        int gravity = 20;
        int score = 0;

        bool gameOver = false;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
        }

        private void GameTimer(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -20;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 20;
            }
            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }
        private void endGame()
        {
            // Đây là hàm kết thúc trò chơi khi con chim chạm đất hay đường ống 
            timer1.Stop();
            ScoreBox.Text += " Trò chơi kết thúc! Nhấn R để chơi lại";
            gameOver = true;
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; // Tăng trọng lực khi con chim lên trên để di chuyển xuống
            Pole1.Left -= pipeSpeed; // Giảm tốc độ vị trí bên trái ống dưới 
            Pole2.Left -= pipeSpeed; // Giảm tốc độ vị trí bên trái ống trên 
            ScoreBox.Text = "Điểm: " + score; //Hiện điểm số hiện tại
            // kiểm tra xem có ống nào rời khỏi màn hình không  
            if (Pole1.Left < -150 & Pole2.Left < -160)
            {
                // Nếu ống rời khỏi màn hình sẽ đặt lại ngẫu nhiên vị trí và sẽ cộng thêm 1 điểm 
                Pole1.Left = rnd.Next(600, 750); //đặt lại ngẫu nhiên vị trí các ống
                Pole2.Left = rnd.Next(600, 760);
                Pole1.Top = rnd.Next(390, 450);
                Pole2.Top = rnd.Next(-100, 50);
                score++;
            }
            // Kiểm tra xem con chim có đụng ống trên, ống dưới không, có chạm đất  không và có vượt độ cao không 
            if (flappyBird.Bounds.IntersectsWith(Pole1.Bounds) ||
                flappyBird.Bounds.IntersectsWith(Pole2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                endGame();//Nếu thực hiện bất kỳ điều kiện nào trò chơi sẽ kết thúc
            }
            if (score > 7)
            {
                pipeSpeed = 20;// Nếu điểm lớn hơn 7 sẽ tăng thêm tốc độ 
            }
        }

        private void RestartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(137, 228);
            Pole2.Left = 800;
            Pole1.Left = 1200;
            score = 0;
            pipeSpeed = 8;
            ScoreBox.Text = "Score: 0 ";
            timer1.Start();


        }
    }
}
