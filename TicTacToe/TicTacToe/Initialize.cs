using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    class Initialize
    {
        // constructor
        public Initialize()
        {
            this.Tab = "X";
            this.CPUTab = "O";    
        }
        //getter
        public string getTabType()
        {
            return Tab;
        }

        public string getCPUTabType()
        {
            return CPUTab;
        }
        //method that evaluates if the tab be X or O
        public void verifier(RadioButton Tab)
        {
            if (Tab.Checked == false)
            {
                this.Tab = "O";
                this.CPUTab = "X";    
            }
            
            
        }

        private string Tab;
        private string CPUTab;


    }
}
