using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace LendingClubMLSite
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbPredict_Click(object sender, EventArgs e)
        {
            // Increase TextFICOLow by four for TextFICOHigh
            int FICOHigh = Convert.ToInt32(txtFICOLow.Text) + 4;

            // Code from PostMan
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/00bdc3fc373e4c65bc3ca23c91c40eea/services/5e035512db624409817f75e7c0f7a358/execute?api-version=2.0&details=true");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "accf7fbc-57d4-445b-b078-bc830794365e");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer vRSU+2k7+T9SaOdDG3dDu9J5mmH/c6F1AFj7Y4vkm9vIBE7TA08aa/yT1VHe4iceYg3c4P/YrGhRdIl8U21Vag==");
            request.AddParameter("undefined", "{\r\n  \"Inputs\": {\r\n    \"input1\": {\r\n      \"ColumnNames\": [\r\n        " +
                "\"loan_status\",\r\n       " +
                "\"loan_purpose\",\r\n        " +
                "\"emp_length\",\r\n        " +
                "\"annual_inc\",\r\n        " +
                "\"dti\",\r\n        " +
                "\"fico_range_low\",\r\n        " +
                "\"fico_range_high\",\r\n        " +
                "\"inq_last_6mths\",\r\n        " +
                "\"revol_util\",\r\n        " +
                "\"total_acc\",\r\n        " +
                "\"tot_cur_bal\",\r\n        " +
                "\"open_rv_24m\",\r\n        " +
                "\"all_util\",\r\n        " +
                "\"inq_last_12m\",\r\n        " +
                "\"acc_open_past_24mths\",\r\n        " +
                "\"mort_acc\"\r\n      ],\r\n      " +
            "\"Values\": [\r\n        [\r\n          " +
                "\"0\",\r\n         " +
                "\"" + ddlLoanPurpose.SelectedValue + "\",\r\n          " +
                "\"" + ddlEmploymentLength.Text + "\",\r\n          " +
                "\"" + txtIncome.Text + "\",\r\n          " +
                "\"" + txtDTI.Text + "\",\r\n          " +
                "\"" + txtFICOLow.Text + "\",\r\n          " +
                "\"" + FICOHigh + "\",\r\n          " +
                "\"" + txtInquiries6.Text + "\",\r\n          " +
                "\"" + txtCreditUtil.Text + "\",\r\n          " +
                "\"" + txtTotAccounts.Text + "\",\r\n          " +
                "\"" + txtTotCurBalance.Text + "\",\r\n          " +
                "\"" + txtRevTrades24.Text + "\",\r\n          " +
                "\"" + txtBalanceToLimit.Text + "\",\r\n          " +
                "\"" + txtInquiries12.Text + "\",\r\n          " +
                "\"" + txtAccountsOpened24.Text + "\",\r\n          " +
                "\"" + txtMortgage.Text + "\"\r\n        ]\r\n      ]\r\n    }\r\n  },\r\n  \"GlobalParameters\": {}\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            // Ending PostMan Code

            // Output Label (Parsed with NewtonSoft Package)
            // lblOutput.Text = response.Content.ToString();    -    old output

            var results = JObject.Parse(response.Content);
            string sPrediction = results["Results"]["output1"]["value"]["Values"].ToString();
            sPrediction = sPrediction.Replace("[", "").Replace("]", "").Replace("\"", "");

            lblOutput.Text = sPrediction.ToString();
        }
    }
}