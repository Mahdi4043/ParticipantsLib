namespace ParticipantsLib
{
    public class Participant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }



        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Max Children: {Age}, Minimum Age: {Country}";
        }
        public void ValidateName()
        {
            if (Name.Trim().Length < 2)
            {
                throw new ArgumentOutOfRangeException("name needs to be at least 2 characters long");
            }
        }
        public void ValidateAge()
        {
            if (Age < 12)
            {
                throw new ArgumentOutOfRangeException("Age needs to be at least 12");
            }
        }
        public void ValidateCountry()
        {
            if (Country.Trim().Length < 3)
            {
                throw new ArgumentOutOfRangeException("Country needs to be at least 3 characters long");
            }
        }
        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateCountry();
        }
    }

}

