﻿using System;
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
            bookingService bs = new bookingService();
            foreach(Booking b in bs.bookings)
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
            bookingService bs = new bookingService();
            foreach(HotelRoom room in bs.rooms)
            {
                if(room.roomId == roomId)
                {
                    Maintenance m = new Maintenance(mt, roomId, maintenanceStatus.Todo, "Nothing to specify");
                }
            }
        }
        void CallService(int roomId, maintenanceType mt, string note)
        {
            bookingService bs = new bookingService();
            foreach (HotelRoom room in bs.rooms)
            {
                if (room.roomId == roomId)
                {
                    Maintenance m = new Maintenance(mt, roomId, maintenanceStatus.Todo, note);
                }
            }
        }

        void addReservation(int customerId, DateTime dateFrom, DateTime dateTo, int nbeds, string s)
        {
            //Noen tanker rundt customerId greiene?
            bookingService bs = new bookingService();


            HotelLibrary.Size size = bs.convertToEnum<HotelLibrary.Size>(s);

            
            Booking b = bs.newBooking(size, nbeds, customerId, dateTo, dateFrom, Status.CheckedIn);

            bs.bookings.Add(b);

        }

        void removeReservation(int customerId, int roomId)
        {
            bookingService bs = new bookingService();
            foreach(Booking b in bs.bookings)
            {
            if(b.roomId == roomId && b.customerId == customerId)
                {
                    bs.bookings.Remove(b);
                }

            }
        }

        
    }

           
}
