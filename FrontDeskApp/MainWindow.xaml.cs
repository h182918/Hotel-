using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HotelLibrary;

namespace FrontDeskApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void DrawMenu()
        {

        }

        void ChangeStatus(int roomId, Status status)
        {
            foreach(Booking b in bookings)
            {
                if (b.roomId == roomId)
                {
                    b.status = status;
                    if(status == Status.CheckedOut)
                    {
                        CallService(b.roomId, maintenanceType.Cleaning, "Client checked out, ready for cleaning");
                    }
                }
            }
        }

        void CallService(int roomId, maintenanceType mt)
        {
            foreach(HotelRoom room in hotelRooms)
            {
                if(room.roomId == roomId)
                {
                    Maintenance m = new Maintenance(mt, roomId, maintenanceStatus.Todo, "Nothing to specify");
                }
            }
        }
        void CallService(int roomId, maintenanceType mt, string note)
        {
            foreach (HotelRoom room in hotelRooms)
            {
                if (room.roomId == roomId)
                {
                    Maintenance m = new Maintenance(mt, roomId, maintenanceStatus.Todo, note);
                }
            }
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Reservation_Click(object sender, RoutedEventArgs e)
        {

        }
    }

           
}
