using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.Dealers.Queries;

public class GetDealerQuery: IRequest<IResponse>
{
    public class GetDealerQueryHandler : IRequestHandler<GetDealerQuery, IResponse>
    {
        private readonly IDealerRepository _dealerRepository;

        public GetDealerQueryHandler(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }
        public async Task<IResponse> Handle(GetDealerQuery request, CancellationToken cancellationToken)
        {
            var dealers = await _dealerRepository.GetListAsync();
            return new Response<IEnumerable<Dealer>>(dealers);
        }
    }
}