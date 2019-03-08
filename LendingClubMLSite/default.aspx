<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LendingClubMLSite._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rob Calcote 12.7 Completed</title>
    <style>
        body {font-family: Arial; font-size: 12px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Rob Calcote - Lending Club Prediction Calculator</h1>
            <h2>This calculator uses a Multi-class Logistic Regression model with an accuracy of 94.5%.</h2>
        </div>

        <table>
            <tr><td>Debt to Income Ratio</td>
                <td><asp:TextBox ID="txtDTI" runat="server"></asp:TextBox></td></tr>
            <tr><td>Loan Purpose</td>
                <td><asp:DropDownList ID="ddlLoanPurpose" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Value="car">Car</asp:ListItem>
                    <asp:ListItem Value="credit_card">Credit Card</asp:ListItem>
                    <asp:ListItem Value="debt_consolidation">Debt Consolidation</asp:ListItem>
                    <asp:ListItem Value="home_improvement">Home Improvement</asp:ListItem>
                    <asp:ListItem Value="house">House</asp:ListItem>
                    <asp:ListItem Value="major_purchase">Major Purchase</asp:ListItem>
                    <asp:ListItem Value="medical">Medical</asp:ListItem>
                    <asp:ListItem Value="moving">Moving</asp:ListItem>
                    <asp:ListItem Value="renewable_energy">Renewable Energy</asp:ListItem>
                    <asp:ListItem Value="small_business">Small Business</asp:ListItem>
                    <asp:ListItem Value="vacation">Vacation</asp:ListItem>
                </asp:DropDownList></td></tr>
            <tr><td>Employment Length:</td>
                <td><asp:DropDownList ID="ddlEmploymentLength" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>&lt; 1 year</asp:ListItem>
                    <asp:ListItem>1 year</asp:ListItem>
                    <asp:ListItem>2 years</asp:ListItem>
                    <asp:ListItem>3 years</asp:ListItem>
                    <asp:ListItem>4 years</asp:ListItem>
                    <asp:ListItem>5 years</asp:ListItem>
                    <asp:ListItem>6 years</asp:ListItem>
                    <asp:ListItem>7 years</asp:ListItem>
                    <asp:ListItem>8 years</asp:ListItem>
                    <asp:ListItem>9 years</asp:ListItem>
                    <asp:ListItem>10+ years</asp:ListItem>
                </asp:DropDownList></td></tr>
            <tr><td>Annual Income:</td>
                <td><asp:TextBox ID="txtIncome" runat="server"></asp:TextBox></td></tr>
            <tr><td>FICO Score:</td>
                <td><asp:TextBox ID="txtFICOLow" runat="server"></asp:TextBox></td></tr>
            <tr><td>Past Inquiries (6 months):</td>
                <td><asp:TextBox ID="txtInquiries6" runat="server"></asp:TextBox></td></tr>
            <tr><td>Rate of Credit Utilization (%):</td>
                <td><asp:TextBox ID="txtCreditUtil" runat="server"></asp:TextBox></td></tr>
            <tr><td>Total Accounts on Credit:</td>
                <td><asp:TextBox ID="txtTotAccounts" runat="server"></asp:TextBox></td></tr>
            <tr><td>Total Current Balance (All Accounts):</td>
                <td><asp:TextBox ID="txtTotCurBalance" runat="server"></asp:TextBox></td></tr>
            <tr><td>Revolving Trades Opened (24 months):</td>
                <td><asp:TextBox ID="txtRevTrades24" runat="server"></asp:TextBox></td></tr>
            <tr><td>Balance to Credit Limit:</td>
                <td><asp:TextBox ID="txtBalanceToLimit" runat="server"></asp:TextBox></td></tr>
            <tr><td>Past Inquiries (12 months):</td>
                <td><asp:TextBox ID="txtInquiries12" runat="server"></asp:TextBox></td></tr>
            <tr><td>Accounts opened (24 months):</td>
                <td><asp:TextBox ID="txtAccountsOpened24" runat="server"></asp:TextBox></td></tr>
            <tr><td>Mortgage Accounts:</td>
                <td><asp:RadioButtonList ID="txtMortgage" runat="server">
                    <asp:ListItem Value="0">No</asp:ListItem>
                    <asp:ListItem Value="1">Yes</asp:ListItem></asp:RadioButtonList></td></tr>
            <!-- Prediction button -->
            <tr><td></td><td><asp:LinkButton ID="lbPredict" runat="server" OnClick="lbPredict_Click">Predict</asp:LinkButton></td></tr>
        </table>
        <br />

        <!-- Output Tag -->
        <h2><asp:Label ID="lblOutput" runat="server" Text="{Prediction Displays Here}"></asp:Label></h2>
        <br />
    </form>
</body>
</html>
