<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateBooking.aspx.cs" Inherits="WebAppClient.CreateBooking.CreateBooking" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 850px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        Find Room <br />
    <br />
    <br />
    Number of beds:<br />
    <asp:DropDownList ID="DropDownList1" runat="server" >
        <asp:ListItem Selected="True" Value="1"> 1 bed </asp:ListItem>
        <asp:ListItem Value="2"> 2 beds </asp:ListItem>
        <asp:ListItem Value="2"> 3 beds </asp:ListItem>
    
    </asp:DropDownList>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Selected="True" Value="Single"> Single</asp:ListItem>
            <asp:ListItem Value="Double">Double</asp:ListItem>
            <asp:ListItem Value="Triple">Triple</asp:ListItem>
            <asp:ListItem Value="Suite">Suite</asp:ListItem>
        </asp:DropDownList>
    <br />



        <br />
        Date from:
        <br />
        
      
        
        
        <asp:Calendar ID="DateFromCalendar" runat="server" SelectedDate='<%# Bind("dateFrom") %>'>

            <SelectedDayStyle BackColor="LightGray" Font-Bold="True"></SelectedDayStyle>
            


        </asp:Calendar>


       <br />

        Date to:


        <br />


        <asp:Calendar ID="DateToCalendar" runat="server" SelectedDate='<%# Bind("dateTo") %>'></asp:Calendar>




        <br />
        <br />
        <asp:Button ID="ButtonSend" runat="server" OnClick="Button1_Click" Text="Check Availability" />


        <b />

       




    </form>

      
</body>
</html>
