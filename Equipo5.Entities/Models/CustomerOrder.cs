using System;

namespace Equipo5.Entities.Models
{
    public class CustomerOrder : IdentityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DataCreated { get; set; }
        public Decimal Amount { get; set; }
        public string CustomerUserName { get; set; }

    }
}