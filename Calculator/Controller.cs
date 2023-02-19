using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    /// <summary>
    /// Interlayer between model and interface.
    /// </summary>
    class Controller 
    {
        private readonly CalculatorModel _calculatorModel;

        public Controller()
        {
            _calculatorModel = new CalculatorModel();
        }
        
        /// <summary>
        /// Handler for click on number.
        /// </summary>
        /// <param name="number">The number on the calculator's screen.</param>
        /// <param name="newnumber">Clicked number.</param>
        /// <returns>Checks for the mistakes.</returns>
        public string NumberClick(string oldNumber, char newNumber) 
        {
            if (oldNumber != "0")
                _calculatorModel.AddNumber(oldNumber, newNumber);
            else
                _calculatorModel.AddNumber("", newNumber);
            return _calculatorModel.GetMistake();
        }

        /// <summary>
        /// Sends information about opertion to the model.
        /// </summary>
        /// <param name="actualOperation">Operation chosen by user.</param>
        public void DoOperation (OperationEnum actualOperation) 
        {
            _calculatorModel.SetFlag(actualOperation); 
        }

        /// <summary>
        /// Returns result of the operation to the interface.
        /// </summary>
        /// <returns>Result of the operation.</returns>
        public string GetResults () 
        {
            _calculatorModel.Res();
            string resultToShow = _calculatorModel.GetMistake();
            if (resultToShow == "")
                resultToShow = _calculatorModel.GetResult();
            return resultToShow;
        }

        /// <summary>
        /// Sends command to clear information in the model.
        /// </summary>
        public void ClearAll ()
        {
            _calculatorModel.Clear();
        }

        /// <summary>
        /// Save the current number.
        /// </summary>
        /// <param name="numberToSave">Number that must be saved.</param>
        public void Save(string numberToSave)
        {
            _calculatorModel.SaveNumber(numberToSave);
        }

        /// <summary>
        /// Takes number from memory.
        /// </summary>
        /// <returns>Number from memory.</returns>
        public string FromMemory ()
        {
            return _calculatorModel.GiveFromMemory().ToString();
        }

        /// <summary>
        /// Sends command to put dot to the model.
        /// </summary>
        /// <returns>Mistakes if there are any.</returns>
        public string PutD() 
        {
            _calculatorModel.PutDot();
            return _calculatorModel.GetMistake();       
        }

        /// <summary>
        /// Takes current number.
        /// </summary>
        /// <returns>Current number.</returns>
        public string TakeNumber() 
        {
            return _calculatorModel.Take();
        }

        /// <summary>
        /// Sends command to the model to del one char in number.
        /// </summary>
        /// <returns>New number with one deleted char.</returns>
        public string Del()
        {
            return _calculatorModel.Delete();
        }
    }
}
