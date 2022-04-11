using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.DealerProductDemands.Command;

public class CreateDealerProductDemandCommand : IRequest<IResponse>
{
    public string Amount { get; set; }

    public int DealerId { get; set; }

    public int ProductId { get; set; }
    

    public class CreateDealerProductDemandHandler : IRequestHandler<CreateDealerProductDemandCommand, IResponse>
    {
        private readonly IDealerProductDemandRepository _dealerProductDemandRepository;

        public CreateDealerProductDemandHandler(IDealerProductDemandRepository dealerProductDemandRepository)
        {
            _dealerProductDemandRepository = dealerProductDemandRepository;
        }

        public async Task<IResponse> Handle(CreateDealerProductDemandCommand request, CancellationToken cancellationToken)
        {
            DealerProductDemand addDealerProductDemand = new DealerProductDemand
            {
                Amount = request.Amount,
                DealerId = request.DealerId,
                ProductId = request.ProductId
            };

            _dealerProductDemandRepository.Add(addDealerProductDemand);
            await _dealerProductDemandRepository.SaveChangesAsync();

            return new Response<DealerProductDemand>(addDealerProductDemand);
        }
    }
}