using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using HotelLibrary;

namespace WebAppClient.CreateBooking
{
    public partial class CreateBooking : System.Web.UI.Page
    {

        bookingService bs = new bookingService();



        List<HotelRoom> rooms;


        List<Booking> bookings;



        //Booking b1 = new Booking(1, 1, DateTime.Now, DateTime.Now.AddDays(1), Status.CheckedIn, "hei");
        //Booking b2 = new Booking(2, 2, DateTime.Now, DateTime.Now.AddDays(1), Status.CheckedIn, "hei");


        //HotelRoom r1 = new HotelRoom(1, Size.Single, 1);
        //HotelRoom r2 = new HotelRoom(2, Size.Single, 1);
        //HotelRoom r3 = new HotelRoom(3, Size.Single, 1);

        //HotelRoom r4 = new HotelRoom(4, Size.Double, 2);
        //HotelRoom r5 = new HotelRoom(5, Size.Double, 2);
        //HotelRoom r6 = new HotelRoom(6, Size.Double, 2);

        //HotelRoom r7 = new HotelRoom(7, Size.Triple, 3);
        //HotelRoom r8 = new HotelRoom(8, Size.Triple, 3);
        //HotelRoom r9 = new HotelRoom(9, Size.Triple, 3);
        //HotelRoom r10 = new HotelRoom(10, Size.Triple, 3);

        //HotelRoom r11 = new HotelRoom(11, Size.Suite, 4);
        //HotelRoom r12 = new HotelRoom(12, Size.Suite, 4);
        //HotelRoom r13 = new HotelRoom(13, Size.Suite, 4);

 
            //rooms.Add(r1);
            //rooms.Add(r2);
            //rooms.Add(r3);
            //rooms.Add(r4);
            //rooms.Add(r5);
            //rooms.Add(r6);
            //rooms.Add(r7);
            //rooms.Add(r8);
            //rooms.Add(r9);
            //rooms.Add(r10);
            //rooms.Add(r11);
            //rooms.Add(r12);
            //rooms.Add(r13);

        


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

        public string showRoom(HotelRoom room)
        {
            string info = "Number of beds:" + room.nBeds.ToString() + " Type of room: " + room.size;
            return info;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
    

           List<HotelRoom> availableRooms = bs.AvailableRooms(bookings, rooms, DateFrom, DateTo, NBeds, Size);

           HotelRoom theRoom = bs.firstValidRoomFromList(availableRooms);

            MessageBox.Show("This room is available, and suits your preferences: " + showRoom(theRoom));

            //Book.Enabled = true;
            //Book.Visible = true;

           // if(bs.firstValidRoomFromList(availableRooms) != null)
            //{

                //Create button - Yes it is available, do you want to book?
                //onmouseclick - makeReservation.

              //  MessageBox.Show("Do you want to book a room from: "+  DateFrom.Date.ToString() + " to " +  DateTo.Date.ToString() + " with "  + NBeds +  " beds and type: " +Size.ToString());


                string name = "yes";
                Button showButton = new Button();

                showButton.CommandName = name;
                showButton.Text = "Yes!";
                showButton.Visible = true;
                showButton.Enabled = true;
                showButton.Click += new EventHandler(this.Button2_Click);
                Controls.Add(showButton);


           // }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Say what");


        }

    }
}