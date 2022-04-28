namespace PassengerTrainFinalProject
{
    public class Passenger
    {
        private string _firstName;
        private string _lastName;
        private string _seat;

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: Passenger()
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/
        public Passenger()
        {
        }

        /**************************************************************
        * Name: Passenger()
        * Description: Constructor that accepts field one, field two and field three
        * Input: string inFirstName, string inLastName, string inSeat
        ***************************************************************/
        public Passenger(string inFirstName, string inLastName, string inSeat)
        {
            _firstName = inFirstName;
            _lastName = inLastName;
            _seat = inSeat;
        }

        /**************************************************************
        * Getters and Setters
        ***************************************************************/
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Seat
        {
            get => _seat;
            set => _seat = value;
        }
    }
}
