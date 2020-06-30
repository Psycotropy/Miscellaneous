using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Winforms01
{
    /// <summary>
    /// A basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }
        #endregion


        #region unusless methods
        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void CEButton_Click(object sender, EventArgs e)
        {
            this.txtUserInputText.Text = string.Empty;
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            DeleteTextValue();

            FocusInputText();
        }



        #region Operator methods


        private void MultButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }
        private void PorcentButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void EqualBotton_Click(object sender, EventArgs e)
        {

            string strNormal = txtUserInputText.ToString();
            string strConverted = cleaner(strNormal);
            ResolveEquation Resolver = new ResolveEquation(strConverted);
            //TODO: implementar mostrar resultado desde el setter problema al convertir str a obj;
            this.CalculationResultText.Text = Resolver.CalculateEquation(strConverted);



            //en una clase
            //Codigo a usar cuando quede implementada la clase
            // +++++++++++++++++++++++++++++++++++++++++++++++++
            //cCalcu oCalcu = new cCalcu();
            //bool bResult = oCalcu.ValidarEntrada(this.txtUserInputText.Text);
            //if (bResult)
            //{
            //    this.CalculationResultText.Text = oCalcu.Resultado(this.txtUserInputText.Text);
            //} else
            //{
            //    this.CalculationResultText.Text = oCalcu.Error();
            //}


        }


        #endregion

        #region Number Methods

        private void PointButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }



        private void FourBotton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }


        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }



        private void CeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }

        #endregion

        #region Private helpers
        private void FocusInputText()
        {
            this.txtUserInputText.Focus();
        }


        private void InsertTextValue(string value)
        {
            var selectionStart = this.txtUserInputText.SelectionStart;
            this.txtUserInputText.Text = this.txtUserInputText.Text.Insert(this.txtUserInputText.SelectionStart, value);
            this.txtUserInputText.SelectionStart = selectionStart + value.Length;
            this.txtUserInputText.SelectionLength = 0;
        }
        private void DeleteTextValue()
        {
            //if we dont have a value to delete
            if (this.txtUserInputText.Text.Length < this.txtUserInputText.SelectionStart + 1)
                return;

        }
      
        private string cleaner(string operation)
        {

            string strSubstring = operation.Substring(35);

            //this.CalculationResultText.Text = strSubstring;
            return strSubstring;
        }
        
        
        #endregion

    }
}
