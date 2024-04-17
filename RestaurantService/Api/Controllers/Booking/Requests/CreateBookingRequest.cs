namespace Api.Controllers.Booking.Requests
{
    public class CreateBookingRequest
    {
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public int CountPeople { get; set; }
        public string Wishes { get; set; }
    }
}
