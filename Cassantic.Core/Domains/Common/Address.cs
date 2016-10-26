using System;


namespace Cassantic.Core.Domains
{
    public class Address : IBaseEntity, ICloneable
    {
        public  string FriendlyName { get; set; }
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Email { get; set; }
        public  string Company { get; set; }
        public  string City { get; set; }
        public  string Address1 { get; set; }
        public  string Address2 { get; set; }
        public  string ZipPostalCode { get; set; }
        public  string PhoneNumber { get; set; }
        public  string FaxNumber { get; set; }
        public  DateTime CreatedOnUtc { get; set; }
        public virtual StateAndCity RegionID { get; set; }

        public object Clone()
        {
            var addr = new Address()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                Company = this.Company,
                City = this.City,
                Address1 = this.Address1,
                Address2 = this.Address2,
                ZipPostalCode = this.ZipPostalCode,
                PhoneNumber = this.PhoneNumber,
                FaxNumber = this.FaxNumber,
                CreatedOnUtc = this.CreatedOnUtc,
            };
            return addr;
        }
    }
}
