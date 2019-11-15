using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class PokerHandController : ControllerBase
    {
        
        [HttpGet]
        public async Task<HandResponseModel> Get()
        {
            //start
            var request = new RequestHandModel();
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new PokerGame.PokerGameClient(channel);
            try
            {
                return await client.GetPokerHandAsync(request, deadline: DateTime.UtcNow.AddMilliseconds(500));
            }
            catch(Grpc.Core.RpcException e)
            {
                Console.WriteLine("------" + e);
                return await Task.Run(() => new HandResponseModel());
            }
            //print now - start
        }
        
        
    }
}