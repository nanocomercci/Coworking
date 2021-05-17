using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class OfficeEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        public int IdAdmin { get; set; }
        public bool HasIndividualWorspace { get; set; }
        public int NumberWorSpaces { get; set; }
        public decimal PriceWorkSpaceDaily { get; set; }
        public decimal PriceWorkSpaceMonthly { get; set; }
        public virtual AdminEntity Admin { get; set; }
        public virtual ICollection<Office2RoomsEntity> Office2Room { get; set; }
        public virtual BookingEntity Booking { get; set; }




    }
}
