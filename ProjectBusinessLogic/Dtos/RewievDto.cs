using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogic.Dtos
{
    public class RewievDto
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime RewievDate { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
