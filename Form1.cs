using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_o_x
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Draggable(true);
            InitializeComponent();
        }

        int sayac = 0;
        string last = "O";
        private void x_yerlestir(object sender, EventArgs e)
        {
            Label a = sender as Label;
            if (last == "X") return;
            if (a.Text.Equals("O") || a.Text.Equals("X"))
            {
                return;
            }
            a.Text = "X";
            last = "X";
            sayac++;
            kontrol("X");
        }
        private void o_yerlestir(object sender, EventArgs e)
        {
            Label a = sender as Label;
            if (last == "O") return;
            if (a.Text.Equals("O")|| a.Text.Equals("X"))
            {
                return;
            }
            a.Text = "O";
            last = "O";
            sayac++;
            kontrol("O");
        }
        private void m_click(object sender, MouseEventArgs e)
        {
            Label a = sender as Label;
            if(e.Button == MouseButtons.Left)
            {
                if(last == "X")
                {
                    o_yerlestir(a,e);
                }
                else
                {
                    x_yerlestir(a, e);
                }
            }
        }
        public void kontrol(string str)
        {
            if (label01.Text == str && label02.Text == str && label03.Text == str) win(str);
            if (label04.Text == str && label05.Text == str && label06.Text == str) win(str);
            if (label07.Text == str && label08.Text == str && label09.Text == str) win(str);
                                                                                      
            if (label01.Text == str && label04.Text == str && label07.Text == str) win(str);
            if (label02.Text == str && label05.Text == str && label08.Text == str) win(str);
            if (label03.Text == str && label06.Text == str && label09.Text == str) win(str);
                                                                                       
            if (label07.Text == str && label05.Text == str && label03.Text == str) win(str);
            if (label01.Text == str && label05.Text == str && label09.Text == str) win(str);

            if (sayac == 9) restrart();
        }
        int x, o;
        public void win(string s)
        {
            MessageBox.Show(s + " KAZANDI");
            if (s == "X")
            {
                x++;
            }
            else if (s == "O")
            {
                o++;
            }
            if (o == 3 || x == 3)
            {
                x = 0;
                o=0;
            }
            scor.Text = x+"-"+o;
            restrart();
        }  
        public void restrart()
        {
            label01.Text = "";
            label02.Text = "";
            label03.Text = "";
            label04.Text = "";
            label05.Text = "";
            label06.Text = "";
            label07.Text = "";
            label08.Text = "";
            label09.Text = "";
            sayac = 0;
        }
    }
}
