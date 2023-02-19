using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    enum OperationEnum
    {
        NoOperation = 0,
        PlusOperation,
        MinusOperation,
        MultipleOperation,
        DivisionOperation,
        SqrtOperation
    }
    class CalculatorModel 
    {
        private double _memoryNum; //number in memory
        private double _mainNum; //current first number
        private double _secondNum; //current second number
        private string _result; //result of the current operation
        OperationEnum _flag; //current operation
        private bool _dot; //dot flag
        private string _mistake; //current mistake (if there is)

        /// <summary>
        /// Constructor of new CalculatorModel.
        /// </summary>
        public CalculatorModel()
        {
            _memoryNum = 0;
            _mainNum = 0;
            _secondNum = 0;
            _flag = OperationEnum.NoOperation;
            _dot = false;
            _result = "";
            _mistake = "";
        }

        /// <summary>
        /// Adds one number to current number.
        /// </summary>
        /// <param name="strNumber">Current number as string.</param>
        /// <param name="newNumber">New number char.</param>
        public void AddNumber (string strNumber, char newNumber) 
        {
            _mistake = "";
            if (strNumber.Length <= 15) 
            {
                double number = Convert.ToDouble(strNumber + newNumber);
                if (_flag == OperationEnum.NoOperation)
                {
                    _mainNum = number;
                }
                else
                {
                    _secondNum = number;
                }
            }
            else
                _mistake = "Too long number!"; 
        }

        /// <summary>
        /// Saves current number.
        /// </summary>
        /// <param name="strNumber">Current number as a string.</param>
        public void SaveNumber (string strNumber) //запоминание числа, введенного пользователем
        {
            _memoryNum = Convert.ToDouble(strNumber);
            _dot = false;
            _mistake = "";
        }

        /// <summary>
        /// Returns number from memory and clears all information about past number.
        /// </summary>
        /// <returns>Number from memory.</returns>
        public double GiveFromMemory ()
        {
            if (_memoryNum.ToString().Contains(','))
                _dot = true;
            else
                _dot = false;
            if (_flag == OperationEnum.NoOperation)
                _mainNum = _memoryNum;
            else
                _secondNum = _memoryNum;
            _mistake = "";
            return _memoryNum;
        }

        /// <summary>
        /// Sets current operation.
        /// </summary>
        /// <param name="toSet">Current operation.</param>
        public void SetFlag (OperationEnum toSet) 
        {
            _dot = false;
            _flag = toSet;
        }

        /// <summary>
        /// Used when users clicks on equality sign. Checks the current operation and then calculates the result.
        /// </summary>
        public void Res () 
        {
            _mistake = "";
            double res;
            switch (_flag) 
            {
                case OperationEnum.PlusOperation:
                    res = Summation();
                    break;
                case OperationEnum.MinusOperation:
                    res = Substraction();
                    break;
                case OperationEnum.DivisionOperation:
                    res = Division();
                    break;
                case OperationEnum.MultipleOperation:
                    res = Multiplication();
                    break;
                case OperationEnum.SqrtOperation:
                    res = Sqrt();
                    break;
                default:
                    res = _mainNum;
                    break;
            }
            _mainNum = res;
            _secondNum = 0;
            _flag = OperationEnum.NoOperation;
            _result = res.ToString();
            if (_result.Contains(','))
                _dot = true;
            else
                _dot = false;
        }

        /// <summary>
        /// Summation of two numbers.
        /// </summary>
        /// <returns>Result of summation.</returns>
        public double Summation() 
        {
            return _mainNum + _secondNum;
        }

        /// <summary>
        /// Substracts one number from another.
        /// </summary>
        /// <returns>Result of substraction.</returns>
        public double Substraction()
        {
            return _mainNum - _secondNum;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <returns>Result of multiplication</returns>
        public double Multiplication()
        {
            return _mainNum * _secondNum;
        }

        /// <summary>
        /// Divides one number by another.
        /// </summary>
        /// <returns>Result of division.</returns>
        public double Division()
        {
            double res;
            if (_secondNum != 0)
                res = _mainNum / _secondNum;
            else
            {
                _mistake = "Division by 0!";
                res = 0;
            }
            return res;
        }

        /// <summary>
        /// Finds square root from the number.
        /// </summary>
        /// <returns>Result.</returns>
        public double Sqrt()
        {
            double res;
            if (_mainNum > 0 && _secondNum == 0)
                res = Math.Pow(_mainNum, 0.5);
            else if (_secondNum > 0)
                res = Math.Pow(_secondNum, 0.5);
            else
            {
                _mistake = "Can't take square root from a negative number";
                res = 0;
            }
            return res;
        }

        /// <summary>
        /// Puts dot to the number.
        /// </summary>
        public void PutDot () 
        {
            _mistake = "";
            if (_dot == false)
                _dot = true;
            else
                _mistake = "Already has dot!";
        }

        /// <summary>
        /// Returns result of the operation.
        /// </summary>
        /// <returns>Result.</returns>
        public string GetResult()
        {
            return _result;
        }

        /// <summary>
        /// Returns mistake as a string.
        /// </summary>
        /// <returns>Mistake.</returns>
        public string GetMistake()
        {
            return _mistake;
        }
        
        /// <summary>
        /// Clears all information of the model.
        /// </summary>
        public void Clear()
        {
            _memoryNum = 0;
            _mainNum = 0;
            _secondNum = 0;
            _flag = OperationEnum.NoOperation;
            _dot = false;
            _result = "";
            _mistake = "";
        }

        /// <summary>
        /// Returns current number.
        /// </summary>
        /// <returns>Current number.</returns>
        public string Take()
        {
            if (_flag == OperationEnum.NoOperation)
                return _mainNum.ToString();
            else
                return _secondNum.ToString();
        }

        /// <summary>
        /// Delete one char from a number.
        /// </summary>
        /// <returns>New number.</returns>
        public string Delete()
        {
            string toDelete = Take();
            if (toDelete.Contains("e") || toDelete.Length <= 1)
                toDelete = "0";
            else
                toDelete = toDelete.Remove(toDelete.Length - 1);
            if (_flag == OperationEnum.NoOperation) 
            {
                _mainNum = Convert.ToDouble(toDelete);
            }
            else
            { 
                _secondNum = Convert.ToDouble(toDelete);
            }
            return toDelete;
        }
    }
}
