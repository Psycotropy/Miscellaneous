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
            CalculateEquation();

            FocusInputText();

            //TODO: Mejorar el encapsulamiento de la logica para la calcu
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
            #endregion

            //remember selection start
            var selectionStart = this.txtUserInputText.SelectionStart;
            // Delete the character to the right of the selection

            this.txtUserInputText.Text = this.txtUserInputText.Text.Remove(this.txtUserInputText.SelectionStart, 1);
            //restore the selection start
            this.txtUserInputText.SelectionStart = selectionStart;

            //set selection lenght to zero
            this.txtUserInputText.SelectionLength = 0;
        }


        private void CalculateEquation()
        {
            //TODO: implement exeption
            bool bResult = false;

            //Limpiar de espacios en los extremos
            string sValue = this.txtUserInputText.Text;
            sValue = sValue.Trim();

            if (sValue.Length > 0)
            {
                bResult = true;
            } else
            {
                bResult = false;
            }
            
            // Validiar que entrada no contenga letras
            if (bResult == true)
            {
                int errorCounter = Regex.Matches(sValue, @"[a-zA-Z]").Count;
                if (errorCounter == 0)
                {
                    bResult = true;
                } else
                {
                    bResult = false;
                }
            }

            //SI lo de arriba paso, ahora me toca a mi
            if (bResult == true)
            {
                //validacion especifica
            }


            if (bResult) { 
                this.CalculationResultText.Text = ParseOperation(sValue);
            }

            // Focus the user input text
            FocusInputText();
        }

        private string ParseOperation(string strEntrada = "0")
        {
            try
            {
                // Get the users equation input
                //var input = this.UserInputText.Text;
                var input = strEntrada;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top-level operation
                var operation = new Operation();
                var leftSide = true;

                // Loop through each character of the input
                // starting from the left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // TODO: Handle order priority
                    //       4.2 + 5.7 * 3
                    //       It should calculate 5 * 3 first, then 4 + the result (so 4 + 15)

                    // Check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    // If it is an operator ( + - * / ) set the operator type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        // If we are on the right side already, we now need to calculate our current operation
                        // and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a right side number
                            if (operation.RightSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an right side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.RightSide += input[i];
                            }
                            else
                            {
                                // Calculate previous equation and set to the left side
                                operation.LeftSide = CalculateOperation(operation);

                                // Set new operator
                                operation.OperationType = operatorType;

                                // Clear the previous right number
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            // Get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // Check if we actually have a left side number
                            if (operation.LeftSide.Length == 0)
                            {
                                // Check the operator is not a minus (as they could be creating a negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an left side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we get here, we have a left number and now an operator, so we want to move to the right side

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;
                            }
                        }
                    }
                }

                //If we are done parsing, and there were no expetions
                //Calcuilate the current operation

                return CalculateOperation(operation);
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        private string CalculateOperation(Operation operation)
        {
            //Store the number values of the string representation
            decimal left = 0;
            decimal right = 0;

            //Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side pf the operation was not a number. {operation.LeftSide}");


            //Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side pf the operation was not a number. {operation.RightSide}");


            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unkonwn operator type whe calculating operation{ operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
            
        }


        /// <summary>
        /// Accepts a character and return the kwon operatioType <see cref="OperationType"/> 
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>


        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;

                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case '*':
                    return OperationType.Multiply;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");

            }

        }

        /// <summary>
        /// Attemps to add a new character to the corrent number
        /// </summary>
        /// <param name="CurrentNumber"></param>
        /// <param name="CurrentCharacter"></param>
        /// <returns></returns>
        private string AddNumberPart(string CurrentNumber, char NewCharacter)
        {
            //Check if there is already a . in the number
            if (NewCharacter == '.' && CurrentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {CurrentNumber} already contains a . and another connot be added");


            return CurrentNumber + NewCharacter;
        }






        


    }
}
