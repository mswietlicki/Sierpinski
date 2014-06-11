using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sierp
{
    public partial class Form1 : Form
    {
        private int _ileZagniezdzen = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCzyszczenia_Click(object sender, EventArgs e)
        {
            var grafika = CreateGraphics();
            grafika.Clear(Color.White);
        }

        public void RysujTrojkat(Graphics gdzie, Pen czym, int x1, int y1, int x2, int y2, int x3, int y3, int ile)
        {
            int x12 = (x1 + x2) / 2;
            int x23 = (x2 + x3) / 2;
            int x31 = (x3 + x1) / 2;
            int y12 = (y1 + y2) / 2;    //współrzędne wewnętrznego trójkąta
            int y23 = (y2 + y3) / 2;
            int y31 = (y3 + y1) / 2;

            gdzie.DrawLine(czym, x1, y1, x2, y2);
            gdzie.DrawLine(czym, x2, y2, x3, y3);
            gdzie.DrawLine(czym, x3, y3, x1, y1);
            if(ile>0)
            {
                ile--;
                RysujTrojkat(gdzie, czym, x1, y1, x12, y12, x31, y31, ile);
                RysujTrojkat(gdzie, czym, x12, y12, x2, y2, x23, y23, ile);
                RysujTrojkat(gdzie, czym, x23, y23, x3, y3, x31, y31, ile);
            }

        }

        private void btnGenerowania_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(liczbaZagniezdzen.Text, out _ileZagniezdzen))
            {
                MessageBox.Show(string.Format("Skąd niby mam wiedzieć ile wynosi {0}???", liczbaZagniezdzen.Text));
            }
            else
            {
                if(_ileZagniezdzen > 10)
                {
                    if(MessageBox.Show("Jesteś pewien? Więcej niż 10 zagnieżdżeń i tak nie widać, a rysować będą się dość długo.", "Uwaga!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DrawBitmap();
                    }
                }
                else if(_ileZagniezdzen < 1)
                {
                    MessageBox.Show("Ujemna lub zerowa ilość nie ma tu sensu.");
                }
                else
                {
                    DrawBitmap();
                }
            }
        }

        private void DrawBitmap()
        {
            int x1 = 10, y1 = 10, x2 = 750, y2 = 10, x3 = 500, y3 = 500;
            var grafika = CreateGraphics();
            var pioro = new Pen(Color.Black, 1);
            RysujTrojkat(grafika, pioro, x1, y1, x2, y2, x3, y3, _ileZagniezdzen);
        }
    }
}
