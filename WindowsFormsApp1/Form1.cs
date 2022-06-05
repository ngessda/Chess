using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Image chessCreateFigurePlatform;
        public int[,] map = new int[8, 8]
        {
            { 15, 14, 13, 12, 11, 13, 14, 15 },
            { 16, 16, 16, 16, 16, 16, 16, 16 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 26, 26, 26, 26, 26, 26, 26, 26 },
            { 25, 24, 23, 22, 21, 23, 24, 25 }
        };
        public Form1()
        {
            InitializeComponent();

            chessCreateFigurePlatform = new Bitmap("D:\\C#\\Chess.App\\WindowsFormsApp1\\WindowsFormsApp1\\ImageFigure\\chess.png");

            Start();
        }
        private void Start()
        {
            CreateMap();
        }
        private void CreateMap()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(i * 50, j * 50);

                    switch (map[j, i] / 10)
                    {
                        case 1:
                            Image part1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(part1);
                            g1.DrawImage(chessCreateFigurePlatform, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[j, i] % 10 - 1), 0, 150, 150, GraphicsUnit.Pixel);
                            button.BackgroundImage = part1;
                            break;
                        case 2:
                            Image part2 = new Bitmap(50, 50);
                            Graphics g2 = Graphics.FromImage(part2);
                            g2.DrawImage(chessCreateFigurePlatform, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[j, i] % 10 - 1), 150, 150, 150, GraphicsUnit.Pixel);
                            button.BackgroundImage = part2;
                            break;
                    }

                    this.Controls.Add(button);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
