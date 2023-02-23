using static AddressBookManagementSystem.PersonDetails;

namespace AddressBookManagementSystem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to The Address Book System");
            //PersonDetails  Details= new PersonDetails("ankita", "patil", "hjkl", "kolhapur", 7588, "Maharashtra",1234567891 , "ankitardeore.com");
            //PersonDetails details = new PersonDetails();
            //details.AddDetails();
            // details.ListingPeople();

         PersonDetails Details = new PersonDetails();

            Details.AddDetails();


            Details.editContact();
            Details.ListingPeople();
        }
    }
}
