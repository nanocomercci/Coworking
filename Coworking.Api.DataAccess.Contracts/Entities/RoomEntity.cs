using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class RoomEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Office2RoomsEntity> Office2Room { get; set; }
        public virtual ICollection<Room2ServicesEntity> Romm2Service { get; set; }

    }
}
