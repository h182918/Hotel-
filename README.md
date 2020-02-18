# Hotel hell
By Helene, Torkel, Elisabeth and Sondre

## Architecture
### WebApp
* Login(User creation)
* Booking(put DB)
* Check status(put DB)
  
### Desktop app
* Manage rooms/reservation
* Add/delete reservation
* Associate reservations with a room
* Check in and out
* Room service and maintenance

### UWP
* Choose occupation
* Pending taks for occupation
* Update tasks through app

### DB
* User
  * Some kind of ID
  * Name
* Rooms
  * number of beds
  * Size
  * RoomId``*``
* Bookings
  * Customer id``*``
  * Room id``*``
  * To 
  * Trom 
  * Note
* Room Service
  * Room id``*``
  * Type of service
  * Note