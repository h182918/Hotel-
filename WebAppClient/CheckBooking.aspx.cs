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

        private TextBox textBox1;
        private FlowDocument flowDoc;
        private Block table1;

        int nBookings;

        public CheckBooking()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        protected void Page_Load(object sender, EventArgs e)
		{

            //if() bruker har bookings så

            //creating a parent FlowDocument()
            flowDoc = new FlowDocument();

            //Creating a table
            flowDoc.Blocks.Add(table1);


            int numberOfColumns = nBookings;

       


        }


    }
}
