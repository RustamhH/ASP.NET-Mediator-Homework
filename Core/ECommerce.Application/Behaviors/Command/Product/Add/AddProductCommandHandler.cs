using ECommerce.Application.Services;
using ECommerce.Domain.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Behaviors.Command.Product.Add
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommandRequest, AddProductCommandResponse>
    {
        private readonly IProductService _productService;
        public AddProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<AddProductCommandResponse> Handle(AddProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _productService.AddProductAsync(request);
            return new AddProductCommandResponse()
            {
                Message = "Product Added Succesfully!"
            };
        }
    }
}
