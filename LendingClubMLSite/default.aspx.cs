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
            // Code from PostMan
            var client = new RestClient("https://ussouthcentral.services.azureml.net/workspaces/00bdc3fc373e4c65bc3ca23c91c40eea/services/bcaec43f7d6b4246a7961dc48f2431b6/execute?api-version=2.0&details=true");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "c0dc32cf-6dc0-4bab-adb1-bb228f593931");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer 25RvQjPnhPcxPtiOjO3OOmfT6pbKYfebiBCP+HlrNwbN4fa8s7gw8HfJ1yfWqSwpTBqxsIjPrXyyalojQkE9ug==");
            request.AddParameter("undefined", "{\r\n  \"Inputs\": {\r\n    \"input1\": {\r\n      " +
                "\"ColumnNames\": [\r\n                             \"loan_status_numeric\",\r\n  \"loan_purpose\",\r\n              \"emp_length\",\r\n       \"home_ownership\",\r\n    \"annual_inc\",\r\n     \"income_verification\",\r\n        \"dti\",\r\n        \"delinq_2yrs\",\r\n        \"earliest_cr_line_days\",\r\n        \"fico_range_low\",\r\n      \"inq_last_6mths\",\r\n     \"mths_since_last_delinq\",\r\n        \"open_acc\",\r\n        \"pub_rec\",\r\n        \"revol_bal\",\r\n        \"revol_util\",\r\n        \"total_acc\",\r\n     \"collections_12_mths_ex_med\",\r\n       \"acc_now_delinq\",\r\n        \"tot_cur_bal\",\r\n       \"open_rv_24m\",\r\n        \"all_util\",\r\n        \"inq_last_12m\",\r\n      \"acc_open_past_24mths\",\r\n       \"chargeoff_within_12_mths\",\r\n       \"delinq_amnt\",\r\n        \"mort_acc\",\r\n        \"pub_rec_bankruptcies\",\r\n      \"tax_liens\"\r\n      ],\r\n      " +
                "\"Values\":      [\r\n  [\r\n                      \"0\",\r\n                    \"debt_consolidation\",\r\n        \"5 years\",\r\n          \"MORTGAGE\",\r\n          \"54600\",\r\n          \"Verified\",\r\n                   \"23.16\",\r\n      \"0\",\r\n                  \"9226\",\r\n                         \"670\",\r\n                 \"1\",\r\n                  \"71\",\r\n                            \"8\",\r\n               \"2\",\r\n              \"5994\",\r\n             \"41\",\r\n                \"18\",\r\n            \"0\",\r\n                                \"0\",\r\n                     \"225591\",\r\n            \"1\",\r\n                  \"41\",\r\n              \"2\",\r\n                 \"3\",\r\n                          \"0\",\r\n                              \"0\",\r\n                  \"2\",\r\n               \"1\",\r\n                         \"0\"\r\n              ]\r\n      ]\r\n    }\r\n  },\r\n  " +
                "\"GlobalParameters\": {}\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            // Ending PostMan Code

            lblOutput.Text = response.Content.ToString();
        }
    }
}