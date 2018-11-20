using System;
namespace LibraryData.Models
{
    public class Patron
    {
        public Patron()
        {
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateofBirth { get; set; }
        public string TelephoneNumber { get; set; }

        //public virtual LibraryCard LibraryCard { get; set; }
        //use virtual keyword when you want to lazy load that property's data
        //lazy loading loada collection from the db the first time it is accessed
    }
}
