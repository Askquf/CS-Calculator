using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form 
    {
        private readonly Controller ButControl; 

        public Form1()
        {
            InitializeComponent();
            ButControl = new Controller();
        }

        /// <summary>
        /// Handles click on button 1.
        /// </summary>
        private void b1_Click(object sender, EventArgs e)
        {
            ShowingNumbers('1');
        }

        /// <summary>
        /// Handles click on button 2.
        /// </summary>
        private void b2_Click(object sender, EventArgs e)
        {
            ShowingNumbers('2');
        }

        /// <summary>
        /// Handles click on button 3.
        /// </summary>
        private void b3_Click(object sender, EventArgs e)
        {
            ShowingNumbers('3');
        }

        /// <summary>
        /// Handles click on button 4.
        /// </summary>
        private void b4_Click(object sender, EventArgs e)
        {
            ShowingNumbers('4');
        }

        /// <summary>
        /// Handles click on button 5.
        /// </summary>
        private void b5_Click(object sender, EventArgs e)
        {
            ShowingNumbers('5');
        }

        /// <summary>
        /// Handles click on button 6.
        /// </summary>
        private void b6_Click(object sender, EventArgs e)
        {
            ShowingNumbers('6');
        }

        /// <summary>
        /// Handles click on button 7.
        /// </summary>
        private void b7_Click(object sender, EventArgs e)
        {
            ShowingNumbers('7');
        }

        /// <summary>
        /// Handles click on button 8.
        /// </summary>
        private void b8_Click(object sender, EventArgs e)
        {
            ShowingNumbers('8');
        }

        /// <summary>
        /// Handles click on button 9.
        /// </summary>
        private void b9_Click(object sender, EventArgs e)
        {
            ShowingNumbers('9');
        }

        /// <summary>
        /// Show number on the calculator screen.
        /// </summary>
        private void ShowingNumbers(char number)
        {
            ShowIt(ButControl.NumberClick(textBox.Text, number)); 
        }

        /// <summary>
        /// Checks for the mistake and shows number on the screen.
        /// </summary>
        /// <param name="mistake"></param>
        private void ShowIt(string mistake)
        {
            if (mistake != "")
            {
                MessageBox.Show(mistake);
            }
            else
            {
                textBox.Text = ButControl.TakeNumber();
            }
        }

        /// <summary>
        /// Handles click on button 0.
        /// </summary>
        private void nul_Click(object sender, EventArgs e) 
        {
            ButControl.NumberClick(textBox.Text, '0'); 
            NulCheck();
        }

        /// <summary>
        /// Checks if null is meaningful.
        /// </summary>
        private void NulCheck()
        {
            if ((ButControl.TakeNumber().CompareTo("0") != 0 || textBox.Text.Length == 0) && (textBox.Text.Length < 15))
                textBox.Text = textBox.Text + "0";
        }

        /// <summary>
        /// Handles division operation.
        /// </summary>
        private void div_Click(object sender, EventArgs e) 
        {
            ClearField();
            ButControl.DoOperation(OperationEnum.DivisionOperation);
        }

        /// <summary>
        /// Handles multiplication operation.
        /// </summary>
        private void mult_Click(object sender, EventArgs e)
        {
            ClearField();
            ButControl.DoOperation(OperationEnum.MultipleOperation);
        }

        /// <summary>
        /// Handles substraction operation.
        /// </summary>
        private void minus_Click(object sender, EventArgs e)
        {
            ClearField();
            ButControl.DoOperation(OperationEnum.MinusOperation);
        }

        /// <summary>
        /// Handles summation operation.
        /// </summary>
        private void plus_Click(object sender, EventArgs e)
        {
            ClearField();
            ButControl.DoOperation(OperationEnum.PlusOperation);
        }

        /// <summary>
        /// Clear of the screen.
        /// </summary>
        private void ClearField() 
        {
            textBox.Text = "0";
        }

        /// <summary>
        /// Handles click on equality sign.
        /// </summary>
        private void eqv_Click(object sender, EventArgs e) 
        {
            DoEqv();
        }

        /// <summary>
        /// Handles square root.
        /// </summary>
        private void sq_root_Click(object sender, EventArgs e)
        {
            ButControl.DoOperation(OperationEnum.SqrtOperation);
            DoEqv();
        }

        /// <summary>
        /// Method for united operation of equality and square root.
        /// </summary>
        private void DoEqv()
        {
            string tmp = ButControl.GetResults();
            if (Char.IsDigit(tmp[0]) || tmp[0] == '-')
                textBox.Text = tmp;
            else
            {
                MessageBox.Show(tmp);
                ClearField();
            }
        }

        /// <summary>
        /// Saves number to the memory.
        /// </summary>
        private void memory_in_Click(object sender, EventArgs e) 
        {
            ButControl.Save(textBox.Text);
            Memory.Text = textBox.Text;
            ClearField();
        }
        
        /// <summary>
        /// Takes number from the memory.
        /// </summary>
        private void memory_out_Click(object sender, EventArgs e)
        {
            textBox.Text = ButControl.FromMemory();
        }

        /// <summary>
        /// Handles delete button.
        /// </summary>
        private void del_Click(object sender, EventArgs e)
        {
            textBox.Text = ButControl.Del();
        }

        /// <summary>
        /// Handles clear all button.
        /// </summary>
        private void clear_all_Click(object sender, EventArgs e)
        {
            ButControl.ClearAll();
            ClearField();
            Memory.Text = "0";
        }

        /// <summary>
        /// Handles dot button.
        /// </summary>
        private void dot_Click(object sender, EventArgs e) 
        {
            string tmp = ButControl.PutD();
            if (tmp.Length == 0 && textBox.Text.Length > 0)
                textBox.Text = textBox.Text + ",";
            else
                MessageBox.Show(tmp);
        }

    }
}
