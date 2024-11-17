using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lipstick._Convergence.DataAccess.DTOs
{
    public class InvoiceDetailsDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }
        public double Quantity { get; set; }
        //public InvoiceDTO Invoice { get; set; }
    }
}
