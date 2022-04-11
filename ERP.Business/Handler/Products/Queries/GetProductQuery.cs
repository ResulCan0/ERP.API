using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.Products.Queries;

public class GetProductQuery : IRequest<IResponse>
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, IResponse>
    {
        private readonly IProductRepository _productRepository;
        
        public GetProductQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetListAsync();
            return new Response<IEnumerable<Product>>(products);
        }
    }
}