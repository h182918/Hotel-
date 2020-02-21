using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelLibrary;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Documents;
using System.Windows.Media;

namespace WebAppClient
{
	public partial class CheckBooking : System.Web.UI.Page
	{

		bookingService bs = new bookingService();

        List<Booking> myBookings = new List<Booking>();

        int myId = 1; 
     

        protected void Page_Load(object sender, EventArgs e)
		{

            DataTable dt = this.getData(bs.bookings);

            StringBuilder html = new StringBuilder();
            html.Append("<table border = '1'>");


            html.Append("<tr>");


            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<th>");
                html.Append(column.ColumnName);
                html.Append("</th>");
            }
            html.Append("</tr>");


            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<td>");
                    html.Append(row[column.ColumnName]);
                    html.Append("</td>");
                }
                html.Append("</tr>");
            }
            //Table end.
            html.Append("</table>");
            string strText = html.ToString();

          


            ////Append the HTML string to Placeholder.
            placeholder.Controls.Add(new Literal { Text = html.ToString() });
   


    }


        public DataTable getData(List<Booking> bookings)
        {

            foreach (Booking b in bs.bookings)
            {
                //if(b.customerId == myId)
                //{
                    myBookings.Add(b);
                //}

            }


            DataTable dt = new DataTable();

            dt.Columns.Add("Room ID", typeof(int));
            dt.Columns.Add("Date From", typeof(DateTime));
            dt.Columns.Add("Date To", typeof(DateTime));
            dt.Columns.Add("Numbers of beds", typeof(int));
            dt.Columns.Add("Type", typeof(HotelLibrary.Size));  //muligens dette må være string

            foreach(Booking b in myBookings)
            {
                foreach(HotelRoom r in bs.rooms)
                {
                    if (b.roomId == r.roomId) {
                        dt.Rows.Add(b.roomId, b.from, b.to, r.nBeds, r.size);
                   }
                }
                
            }
           



            return dt;
        }


    }
}
