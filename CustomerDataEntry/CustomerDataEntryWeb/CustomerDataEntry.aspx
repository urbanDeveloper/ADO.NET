<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDataEntry.aspx.cs" Inherits="CustomerDataEntryWeb.CustomerDataEntry" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblCustomerName" runat="server" Text="CustomerName"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br><br>
        <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="130px">
            <asp:ListItem>India</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>UK</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br><br>
        <asp:Label ID="lblGender" runat="server" Text="Gender"></asp:Label>
&nbsp;<asp:RadioButton ID="rdoMale" runat="server" GroupName="Gender" Text="Male">
        </asp:RadioButton>
        <asp:RadioButton ID="rdoFemale" runat="server" GroupName="Gender" Text="Female">
        </asp:RadioButton>
        <br><br>
        <asp:Label ID="lblHobbies" runat="server" Text="Hobbies"></asp:Label>
&nbsp;<asp:CheckBox ID="chkReading" runat="server" Text="Reading"></asp:CheckBox>
        <asp:CheckBox ID="chkSports" runat="server" Text="Sports"></asp:CheckBox>
        <br><br>
        <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label>
&nbsp;<asp:RadioButton ID="rdoMarried" runat="server" GroupName="Status" Text="Married">
        </asp:RadioButton>
        <asp:RadioButton ID="rdoUnmarried" runat="server" GroupName="Status" 
        Text="Unmarried"></asp:RadioButton>
        <br><br><br>
        <asp:Button ID="btnAdd" runat="server" Height="28px" Text="Add" Width="53px">
        </asp:Button>
        <asp:Button ID="btnUpdate" runat="server" Height="28px" Text="Update" 
        Width="53px"></asp:Button>
        <asp:Button ID="btnDelete" runat="server" Height="28px" Text="Delete" 
        Width="53px"></asp:Button>
        <br><br>
        <asp:GridView ID="GridViewCustomers" runat="server" Width="623px">
        </asp:GridView>
        <br><br>
    
    </div>
    </form>
</body>
</html>
