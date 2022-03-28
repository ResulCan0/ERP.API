using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.Dealers.Command;

public class DeleteDealerCommand : IRequest<IResponse>
{
    public int DealerId { get; set; }

    public class DeleteDealerCommandHandler : IRequestHandler<DeleteDealerCommand, IResponse>
    {
        private readonly IDealerRepository _dealerRepository;

        public DeleteDealerCommandHandler(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public async Task<IResponse> Handle(DeleteDealerCommand request, CancellationToken cancellationToken)
        {
            Dealer deleteDealer = await _dealerRepository.GetAsync(_ => _.DealerId == request.DealerId);

            _dealerRepository.Delete(deleteDealer);
            await _dealerRepository.SaveChangesAsync();

            return new Response<Dealer>(deleteDealer);
        }
    }
}