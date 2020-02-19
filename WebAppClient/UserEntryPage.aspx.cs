using HotelLibrary;
using System;

namespace WebAppClient
{
    public partial class UserEntryPage : System.Web.UI.Page
    {

        List<Booking> bookings;
        protected void Page_Load(object sender, EventArgs e)
        {
            //bookings = DB.getbookings(userID)
            //if user has bookings 
            //list active bookings
        }


        // en kommentar
        protected void CheckBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
        protected void CreateBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateBooking.aspx");
        }
    }
}