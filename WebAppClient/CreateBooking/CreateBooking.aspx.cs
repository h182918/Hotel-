using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelLibrary;

namespace WebAppClient.CreateBooking
{
    public partial class CreateBooking : System.Web.UI.Page
    {

        List<Booking> bookings;
        List<HotelRoom> rooms;

        bookingService bookingService = new bookingService();

        protected void Page_Load(object sender, EventArgs e)
        {



           
            //DropDownList DropList = new DropDownList();

            //DropList.ID = "nbeds";
            //DropList.AutoPostBack = true;

            //DropList.DataBind();


            //set date
            //bruker velger date, beds size 

            //skriver ut et rom som er ledig
            //button 
            //book this room - db

            //--- Show results in page.
        



        }

        protected List<HotelRoom> AvailableRooms(DateTime dateFrom, DateTime dateTo, int nBeds, string size)
        {
            var validRooms = rooms.Where(i => i.nBeds == nBeds && i.size.Equals(size));

            dateFrom = DateFromCalendar.SelectedDate;
            dateTo = DateToCalendar.SelectedDate;  //litt usikker på om dette fungerer

            nBeds = int.Parse(DropDownList1.Items.FindByValue("1").Value); //usikker på dette og må teste


            List<HotelRoom> validR = validRooms.ToList();


            //loop through rooms 
            foreach (HotelRoom r in validR)
            {
                if (!DateCheck(dateFrom, dateTo, r))
                
                {
                    validR.Remove(r);
                }


            }
            return validR;
    

        }

      

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}