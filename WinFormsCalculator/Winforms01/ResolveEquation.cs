using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Winforms01
{
    class ResolveEquation
    {
        public ResolveEquation(string strOperation)
        {
            this.strOperation = strOperation;
            this.result = strOperation;
        }

        public string getOperation()
        {
            
            return result;
        }

        


         public string CalculateEquation(string STRoperation)
        {
            bool bverification = first_verification(strOperation);
            if (bverification == false)
                throw new InvalidOperationException("Porfavor ingrese un valor valido");
            else
                result = ParseEquation();

            return result;


        }


        #region Debug_layers
        public bool first_verification(string strOperation)
        {

            bool bResult = false;

            //Limpiar de espacios en los extremos
            string sValue = strOperation;
            sValue = sValue.Trim();

            if (sValue.Length > 0)
            {
                bResult = true;
            }
            else
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
                }
                else
                {
                    bResult = false;
                }
            }

            return bResult;

        }


        #endregion

        #region Parse Ecuation

        private string ParseEquation()
        {
            try
            {
                // Get the users equation input
                //var input = this.UserInputText.Text;
                var input = this.strOperation;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top-level operation
                var operation = new Operation();
                bool leftSide = true;

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

        #endregion

        #region private Helpers

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

        private string CalculateOperation(Operation operation)
        {
            //Store the number values of the string representation
            decimal left = 0;
            decimal right = 0;

            //Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");


            //Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");


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
                        throw new InvalidOperationException($"Unkonwn operator type when calculating operation{ operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
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


        #endregion

        private string strOperation;
        private string result;



    }
}
