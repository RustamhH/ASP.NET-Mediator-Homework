using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Behaviors.Command.Product.Update
{
    public class UpdateProductCommandResponse
    {
        public string Message { get; set; }
    }
}
