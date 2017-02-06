using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFCalcWebClient.CalcService;

namespace WCFCalcWebClient
{
    public partial class WCFCalcWebForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ButtonEquals_Click(object sender, EventArgs e)
        {
            labelOutput.ForeColor = Color.Black;

            try
            {
                CalcService.CalcServiceClient client = new CalcServiceClient("BasicHttpBinding_ICalcService");
                labelOutput.Text = client.PerformOperation(textBoxOperandLeft.Text, textBoxOperandRight.Text,
                    dropDownOperator.Text[0]);
            }
            catch (EndpointNotFoundException)
            {
                labelOutput.Text = "Error: WCFCalcService endpoint could not be reached";
                labelOutput.ForeColor = Color.Red;
            }
        }
    }
}