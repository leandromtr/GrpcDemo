using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services.Example2
{
    public class MeterServices : MeterReadingService.MeterReadingServiceBase
    {
        //private readonly ILogger<MeterServices> _logger;
        //private readonly IReadingRepository _repository;
        //public MeterServices(ILogger<MeterServices> logger, IReadingRepository repository)
        //{
        //    _logger = logger;
        //}

        //public override Task<StatusMessage> AddReading(ReadingPacket request, ServerCallContext context)
        //{
        //    var result = new StatusMessage()
        //    {
        //        Success = ReadingStatus.Failure
        //    };

        //    if (request.Successful == ReadingStatus.Success)
        //    {
        //        try
        //        {

        //        foreach(var r in request.Reading)
        //        {

        //        }
        //        }
        //        catch (Exception)
        //        {
        //            result.Message = "Exeption throw during the process";
        //        }
        //    }

        //    return Task.FromResult(result);
        //}
    }
}
