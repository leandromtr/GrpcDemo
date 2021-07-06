﻿using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class CustomersService : Customer.CustomerBase
    {
        private readonly ILogger<CustomersService> _logger;
        public CustomersService(ILogger<CustomersService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustomerLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();

            if (request.UserId == 1)
            {
                output.FirstName = "Leandro";
                output.LastName = "Reis";
            }
            else if (request.UserId == 2)
            {
                output.FirstName = "Lucas";
                output.LastName = "Souza";
            }
            else
            {
                output.FirstName = "Teteus";
                output.LastName = "Reis";
            }

            return Task.FromResult(output);
        }

    }
}