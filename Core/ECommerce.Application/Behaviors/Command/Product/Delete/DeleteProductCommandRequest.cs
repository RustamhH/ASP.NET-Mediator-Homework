using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Behaviors.Command.Product.Delete
{
    public class DeleteProductCommandRequest:IRequest<DeleteProductCommandResponse>
    {
        public int Id { get; set; } 
    }
}
