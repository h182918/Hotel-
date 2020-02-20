<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateBooking.aspx.cs" Inherits="WebAppClient.CreateBooking.CreateBooking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 754px;
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
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    
    
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








    </form>

      
</body>
</html>
