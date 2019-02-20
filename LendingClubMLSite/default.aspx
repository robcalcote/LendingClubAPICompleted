<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="LendingClubMLSite._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rob Calcote 21.2 Completed</title>
    <style>
        body {font-family: Arial; font-size: 12px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Rob Calcote Lending Club Prediction Calculator</h1>
        </div>


        <asp:LinkButton ID="lbPredict" runat="server" OnClick="lbPredict_Click">Predict</asp:LinkButton>
        <asp:Label ID="lblOutput" runat="server" Text="{Prediction Displays Here}"></asp:Label>

    </form>
</body>
</html>
