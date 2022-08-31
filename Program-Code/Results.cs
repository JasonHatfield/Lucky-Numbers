// Jason Hatfield
// This is my original work.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky_Numbers
{
    public partial class Results : Form
    {
        public Results(int luckyNumber)
        {
            InitializeComponent();
            //Results.outputLabel.Text = luckyNumber.ToString();
            resultLabel.Text = luckyNumber.ToString();            
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            // creates a new luckyNumber form
            LuckyNumber luckyNumber = new LuckyNumber();
            // hides this from
            this.Hide();
            // shows the luckyNumber form
            luckyNumber.Show();
        }
    }
}
