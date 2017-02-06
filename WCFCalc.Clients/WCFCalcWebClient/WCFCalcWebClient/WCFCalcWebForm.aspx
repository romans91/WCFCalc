<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WCFCalcWebForm.aspx.cs" Inherits="WCFCalcWebClient.WCFCalcWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family: Calibri">
        <asp:TextBox ID="textBoxOperandLeft" runat="server" Width="200"></asp:TextBox>
        <asp:DropDownList ID="dropDownOperator" runat="server" Width="45">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
            <asp:ListItem>%</asp:ListItem>
            <asp:ListItem>^</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="textBoxOperandRight" runat="server" Width="200"></asp:TextBox>
        <asp:Button ID="buttonEquals" runat="server" Text="=" OnClick="ButtonEquals_Click" Width="100"/>
        &nbsp;
        </div>
        <p>
        <asp:Label ID="labelOutput" runat="server" Width="558px"></asp:Label>
        </p>
    </form>
</body>
</html>
