using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erwins_Italian_Shack.Domain.Infrastructure
{
    public class BaseModel
    {
        public BaseModel()
        {
            this.Timestamp = DateTime.UtcNow;
        }

        public Guid? Id { get; set; }
        //Property
        public DateTime Timestamp { get; set; }
    }
}
