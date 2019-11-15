using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcServer
{
    public class PokerGameService : PokerGame.PokerGameBase
    {
        private readonly ILogger<PokerGameService> _logger;
        
        public PokerGameService(ILogger<PokerGameService> logger)
        {
            _logger = logger;
        }

        public override Task<HandResponseModel> GetPokerHand(RequestHandModel request, ServerCallContext context)
        {
            CardModel card = new CardModel();
            card.Kind = CardModel.Types.Kind.Diamonds;
            card.Value = CardModel.Types.Value.King;
            
            HandResponseModel response = new HandResponseModel();
            response.Card.Add(card);
            response.Card.Add(card);
            response.Card.Add(card);
            response.Card.Add(card);
            response.Card.Add(card);


            return Task.FromResult(response);
        }
    }
}