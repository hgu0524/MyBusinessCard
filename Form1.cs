using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.instagram.com/geun_wo0o/",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\사용자\\OneDrive\\Desktop\\짱구.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // 힌트 적용: 테두리 스타일을 고정 3D로 변경
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // 다시 테두리를 없앰
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
