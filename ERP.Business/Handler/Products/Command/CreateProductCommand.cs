using Core.Constants;
using ERP.Business.Helper;
using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.Products.Command;

public class CreateProductCommand : IRequest<IResponse>
{
    public string ProductName { get; set; }

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, IResponse>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product addProduct = new Product();
            addProduct.Name = request.ProductName;

            var productControl = await _productRepository.GetByProductName(addProduct.Name);

            if (addProduct.Name=="string")
            {
                throw new UserFriendlyException(Messages.NotEmpty, new List<string>()
                {
                    $"Alanı Boş Bırakmayınız. (string) Kabul Edilmez."
                });
            }

            if (productControl.Count()!=0)
            {
                throw new UserFriendlyException(Messages.NameAlreadyExist, new List<string>()
                {
                    $"{addProduct.Name} İsimli Ürün Sistemde Kayıtlıdır."
                });
            }
            
            
            _productRepository.Add(addProduct);
            await _productRepository.SaveChangesAsync();

            return new Response<Product>(addProduct);
        }
    }
}