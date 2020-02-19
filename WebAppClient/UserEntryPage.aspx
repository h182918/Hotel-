<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserEntryPage.aspx.cs" Inherits="WebAppClient.UserEntryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WELCOME!!</title>
</head>
<body style="font-family: Arial, Helvetica, sans-serif; font-size: small">
    <form id="form1" runat="server">
        <div>
            <h4 style="font-size: medium">Hello there!!</h4>
            <hr />
            <p>
                <asp:Literal runat="server" ID="StatusMessage" />
            </p>
            <div>
                <div>
                    <asp:Button runat="server" OnClick="CheckBooking_Click" Text="My bookings" />
                </div>
            </div>
            <div>
                <div>
                    <asp:Button runat="server" OnClick="CreateBooking_Click" Text="New booking" />
                </div>
            </div>

            <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="roomId" HeaderText="Room #" />
                    <asp:BoundField DataField="dateFrom" HeaderText="From" />
                    <asp:BoundField DataField="dateTo" HeaderText="To" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
