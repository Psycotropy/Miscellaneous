using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.playFlag = false;
            UsedPosc = new List<int>();
            count = 0;
            


        }
        public void setRandomPosc(int element)
        {
            this.randomPosc = element;
        }

   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Length == 0 && playFlag == true)
            {
                button1.Text = this.UsrTab;
                UsedPosc.Add(1);
                TrunkFunction();             
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (button2.Text.Length == 0 && playFlag == true) 
            {
                button2.Text = this.UsrTab;
                UsedPosc.Add(2);
                TrunkFunction();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text.Length == 0 && playFlag == true)
            {
                button3.Text = this.UsrTab;
                UsedPosc.Add(3);
                TrunkFunction();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text.Length == 0  && playFlag == true)
            {
                button4.Text = this.UsrTab;
                UsedPosc.Add(4);
                TrunkFunction();
            }
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text.Length == 0 && playFlag == true)
            {
                button5.Text = this.UsrTab;
                UsedPosc.Add(5);
                TrunkFunction();
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text.Length == 0 && playFlag == true)
            {
                button6.Text = this.UsrTab;
                UsedPosc.Add(6);
                TrunkFunction();
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text.Length == 0 && playFlag == true)
            {
                button7.Text = this.UsrTab;
                UsedPosc.Add(7); 
                TrunkFunction();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text.Length == 0 && playFlag == true)
            {
                button8.Text = this.UsrTab;
                UsedPosc.Add(8);
                TrunkFunction();
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text.Length == 0 && playFlag == true)
            {
                button9.Text = this.UsrTab;
                UsedPosc.Add(9); 
                TrunkFunction();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (playFlag == false)
            {
                Initialize verify = new Initialize();
                verify.verifier(radioButton2);
                this.UsrTab = verify.getTabType();
                this.CPUTab = verify.getCPUTabType();
                MessageBox.Show("You play like : " + this.UsrTab);
                this.playFlag = true;
            }
            
        }

        #region Trunk Function
        //This function resume all procedures and derives task to other class and methods

        IntMethods play = new IntMethods();
        private void TrunkFunction()
        {
            if(count != 4)
            {
                SendUsedPosc();
                //play.printList();
                setRandomPosc(play.Play());
                
                ComputerWriter(this.randomPosc);
                
                
                count++;
            }
            else
            {
                MessageBox.Show("El programa se ha terminado");
                ComputerWriter(10);
            }
            
            
            
            
           
        } 
        #endregion

        #region Helpers                  
        private void ComputerWriter(int position)
        {

            switch (position)
            {
                case 1:
                    button1.Text = CPUTab;
                    break;
                case 2:
                    button2.Text = CPUTab;
                    break;
                case 3:
                    button3.Text = CPUTab;
                    break;
                case 4:
                    button4.Text = CPUTab;
                    break;
                case 5:
                    button5.Text = CPUTab;
                    break;
                case 6:
                    button6.Text = CPUTab;
                    break;
                case 7:
                    button7.Text = CPUTab;
                    break;
                case 8:
                    button8.Text = CPUTab;
                    break;
                case 9:
                    button9.Text = CPUTab;
                    break;
                case 10:
                    MessageBox.Show("gracias por jugar");
                    break;

            }
        }

        

        
        
        private void SendUsedPosc()
        {
           
            
            for (int i = 0; i < UsedPosc.Count; i++)
            {
                //MessageBox.Show("Se ha enviado desde form a generic list : " + UsedPosc[i]);
                int tempvar = UsedPosc[i];
                play.setValues(ref tempvar, UsedPosc.Count);
                
            }
            UsedPosc.Clear();

            

        }

        


        #endregion

        List<int> UsedPosc;
        private int count;
        private int randomPosc;
        private string UsrTab;
        private string CPUTab;
        private bool playFlag;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
