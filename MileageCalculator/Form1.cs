using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        private int _startingMileage;
        private int _endingMileage;
        private double _milesTraveled;
        private decimal _reimburseRate = 0.39M;
        private double _amountOwed;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            _startingMileage = (int) startingMileageBox.Value;
            _endingMileage = (int) endingMileageBox.Value;
            _milesTraveled = _endingMileage - _startingMileage;
            _amountOwed = _milesTraveled * (double) _reimburseRate;

            if (_startingMileage < _endingMileage)
            {
                calculationAmount.Text = $@"${_amountOwed}";
            }
            else
            {
                MessageBox.Show(@"Cannot Calculate Mileage");
            }
        }
    }
}
