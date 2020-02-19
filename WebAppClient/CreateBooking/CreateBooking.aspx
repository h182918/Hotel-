<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateBooking.aspx.cs" Inherits="WebAppClient.CreateBooking.CreateBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

<form runat="server">
Enter your name:
<asp:TextBox id="txt1" runat="server" />
<asp:Button OnClick="submit" Text="Submit" runat="server" />
<p><asp:Label id="lbl1" runat="server" /></p>
</form>

    <asp:DropDownList ID="DropDownList1" runat="server" Label="Number of beds">
        <asp:ListItem ID="nBeds" runat="server" Text="1 bed" Value="1">
        </asp:ListItem>

        <asp:ListItem ID="ListItem2" runat="server" Text="2 bed" Value="2">
        </asp:ListItem>


    </asp:DropDownList>


</body>
</html>
