<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SalaryCalcASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please choose the frequency of your income from the list&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>Weekly</asp:ListItem>
            <asp:ListItem>Monthly</asp:ListItem>
            <asp:ListItem>Yearly</asp:ListItem>
        </asp:DropDownList>
    
    </div>
        <p>
            How do you earn in the duration you mentioned above&nbsp;&nbsp;
            <asp:TextBox ID="salaryInputTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="calcButton" runat="server" OnClick="calcButton_Click" Text="Click Me" />
        </p>
        <p>
            This is how much you earn after Tax and NI per year:&nbsp;
            <asp:Label ID="perAnnumResultLabel" runat="server"></asp:Label>
&nbsp; per month:
            <asp:Label ID="perMonthResultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
