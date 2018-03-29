using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset();
        }
        int Counter;
        bool X;
        int[] History = new int[9];
        int i = 0 ; 
        private void xPlayerName_TextChanged(object sender, EventArgs e)
        {
            xName.Text = xPlayerName.Text;
        }

        private void oPlayerName_TextChanged(object sender, EventArgs e)
        {
            oName.Text = oPlayerName.Text;
        }
        void Reset()
        {
            Cell1.Text = "";
            Cell2.Text = "";
            Cell3.Text = "";
            Cell4.Text = "";
            Cell5.Text = "";
            Cell6.Text = "";
            Cell7.Text = "";
            Cell8.Text = "";
            Cell9.Text = "";
            i = 0;
            if (X)
            {
                Counter = 0;
            }
            else
            {
                Counter = 1;
            }

        }
        private void reset_Click(object sender, EventArgs e)
        {
            if (xRadio.Checked)
            {
                Counter = 0;
            }
            else
            {
                Counter = 1;
            }
            Reset();
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            yScore.Text = "0"; xScore.Text = "0";
        }
        void Checker()
        {
            Equality(0,4,8);
            Equality(2,4,6);
            Equality(0,3,6);
            Equality(1,4,7);
            Equality(2,5,8);
            Equality(0,1,2);
            Equality(3,4,5);
            Equality(6,7,8);
        }
        void Equality(int x , int y , int z)
        {
            String[] cells = new String[9];
            cells[0] = Cell1.Text;
            cells[1] = Cell2.Text;
            cells[2] = Cell3.Text;
            cells[3] = Cell4.Text;
            cells[4] = Cell5.Text;
            cells[5] = Cell6.Text;
            cells[6] = Cell7.Text;
            cells[7] = Cell8.Text;
            cells[8] = Cell9.Text;
            String Fin = cells[x] + cells[y] + cells[z];
            if (Fin == "XXX")
            {
                MessageBox.Show(xPlayerName.Text + " Wins !", "The Winner");
                xScore.Text= (Int32.Parse(xScore.Text)+1).ToString();
                Reset();
            }
            else if (Fin == "OOO")
            {
                MessageBox.Show(oPlayerName.Text+ " Wins !","The Winner");
                yScore.Text = (Int32.Parse(yScore.Text) + 1).ToString();
                Reset();
            }
        }
        private void Cell1_Click(object sender, EventArgs e)
        {
            
            if (Cell1.Text == "")
            {
                History[i] = 1;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell1.Text = "X";
                }
                else
                {
                    Cell1.Text = "O";
                }
            }
            Counter++;Checker(); 

        }

        private void Cell2_Click(object sender, EventArgs e)
        {
            
            if (Cell2.Text == "")
            {
                History[i] = 2;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell2.Text = "X";
                }
                else
                {
                    Cell2.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void Cell3_Click(object sender, EventArgs e)
        {
            
            if (Cell3.Text == "")
            {
                History[i] = 3;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell3.Text = "X";
                }
                else
                {
                    Cell3.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void Cell4_Click(object sender, EventArgs e)
        {
            
            if (Cell4.Text == "")
            {
                History[i] = 4;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell4.Text = "X";
                }
                else
                {
                    Cell4.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void Cell5_Click(object sender, EventArgs e)
        {
           
            if (Cell5.Text == "")
            {
                History[i] = 5;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell5.Text = "X";
                }
                else
                {
                    Cell5.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void Cell6_Click(object sender, EventArgs e)
        {
          
            if (Cell6.Text == "")
            {
                History[i] = 6;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell6.Text = "X";
                }
                else
                {
                    Cell6.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void Cell7_Click(object sender, EventArgs e)
        {
            
            if (Cell7.Text == "")
            {
                History[i] = 7;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell7.Text = "X";
                }
                else
                {
                    Cell7.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void Cell8_Click(object sender, EventArgs e)
        {
            if (Cell8.Text == "")
            {
                History[i] = 8;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell8.Text = "X";
                }
                else
                {
                    Cell8.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void Cell9_Click(object sender, EventArgs e)
        {
            if (Cell9.Text == "")
            {
                History[i] = 9;
                i++;
                if ((Counter % 2) == 0)
                {
                    Cell9.Text = "X";
                }
                else
                {
                    Cell9.Text = "O";
                }
            }
            Counter++;Checker();
        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void yRadio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void xRadio_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void yRadio_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (xRadio.Checked)
            {
                X = true;
            }
            else
            {
                X = false;
            }
            if (History[0]>0)
            {
                Reset();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((History[0] > 0)&&(i>0))
            {
                switch (History[i - 1])
                {
                    case 1:
                        Cell1.Text = "";
                        break;
                    case 2:
                        Cell2.Text = "";
                        break;
                    case 3:
                        Cell3.Text = "";
                        break;
                    case 4:
                        Cell4.Text = "";
                        break;
                    case 5:
                        Cell5.Text = "";
                        break;
                    case 6:
                        Cell6.Text = "";
                        break;
                    case 7:
                        Cell7.Text = "";
                        break;
                    case 8:
                        Cell8.Text = "";
                        break;
                    case 9:
                        Cell9.Text = "";
                        break;
                }
                History[i - 1] = 0;
                i--;
                Counter--;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Aux = xPlayerName.Text;
            xPlayerName.Text = oPlayerName.Text;
            oPlayerName.Text = Aux; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }


    }
}
