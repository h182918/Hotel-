using HotelLibrary;
using System;
using System.Collections.Generic;

namespace WebAppClient
{
    public partial class UserEntryPage : System.Web.UI.Page
    {
       // private readonly List<Booking> bookings;



        protected void Page_Load(object sender, EventArgs e)
        {
            //bookings = DB.getbookings(userID)
            //if user has bookings 


            //foreach (Booking b in bookings)
            //{
            //    if (b.customerId != -1)  //må sette customerID til -1 hvis det ikke finnes
            //    {

                    // show grid
                    //GridView.DataSource =  

                    //        = b.roomId;

                    //        dx.student.Where(s => s.studentage > 30).ToList();
                    //    GridView.DataBind();
                    //}

                    //}
                    //{
            //    }
            //}

        
        }


        // en kommentar
        protected void CheckBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("CheckBooking.aspx");
        }
        protected void CreateBooking_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateBooking.aspx");
        }
    }
}