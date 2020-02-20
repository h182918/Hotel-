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

        bookingService bs = new bookingService();
      
        Size Size
        {
            get
            {
                return bs.convertToEnum<Size>(DropDownList2.SelectedValue);
                    
            
            }
        }


        DateTime DateFrom
        {

            get
            {

                return DateFromCalendar.SelectedDate.Date;
            }
          
        }


            DateTime DateTo
            {
              
                get {
                    return DateToCalendar.SelectedDate.Date;
                }
            }

        int NBeds
        {
            get
            {
                return int.Parse(DropDownList1.SelectedValue);
            }

            set { NBeds = value; }
        }




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
       

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            List<HotelRoom> availableRooms = bs.AvailableRooms(bookings, rooms, DateFrom, DateTo, NBeds, Size);

            if(bs.firstValidRoomFromList(availableRooms) != null)
            {
                
                //Create button - Yes it is available, do you want to book?
                //onmouseclick - makeReservation.

            }

        }
    }
}