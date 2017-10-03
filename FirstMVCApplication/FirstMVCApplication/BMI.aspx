<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BMI.aspx.cs" Inherits="FirstMVCApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BMI Calculator</title>
</head>
<body>
    <h1>BMI Calculator</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label">Enter your height</asp:Label>
            <br /><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>cm
            <br /><br />
            <asp:Label ID="Label2" runat="server" Text="Label">Enter your weight</asp:Label>
            <br /><br />
            
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>Kg
            <br /><br />
            <asp:Button ID="BmiCalculate" runat="server" Text="Calculate" OnClick="Button1_Click" />
            <br /><br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
