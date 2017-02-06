using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFCalcWinClient.CalcService;

namespace WCFCalcWinClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxOperator.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelResult.ResetForeColor();

            try
            {
                CalcService.CalcServiceClient client = new CalcServiceClient("NetTcpBinding_ICalcService");
                labelResult.Text = client.PerformOperation(textBoxOperandLeft.Text, textBoxOperandRight.Text,
                    comboBoxOperator.Text[0]);
            } catch (EndpointNotFoundException)
            {
                labelResult.Text = "Error: WCFCalcService endpoint could not be reached";
                labelResult.ForeColor = Color.Red;
            }
        }
    }
}
