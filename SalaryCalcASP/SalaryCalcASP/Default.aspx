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
            How much do you earn in the duration you mentioned above&nbsp;&nbsp;
            <asp:TextBox ID="salaryInputTextBox" runat="server" OnTextChanged="salaryInputTextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            To find out how much you earn per year before any deductions&nbsp; <asp:Button ID="calcButton" runat="server" OnClick="calcButton_Click" Text="Click Me" style="height: 26px" />
        &nbsp;
            <asp:Label ID="resultBeforeDeductionsLabel" runat="server"></asp:Label>
        </p>
        <p>
            Would you like a to know how much tax and NI you will have to pay?&nbsp;
            <asp:Button ID="yesButton" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Yes" Width="30px" />
&nbsp;
            <asp:Button ID="noButton" runat="server" OnClick="noButton_Click" Text="No" Width="30px" />
        </p>
        <p>
            <asp:Label ID="breakdownLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
