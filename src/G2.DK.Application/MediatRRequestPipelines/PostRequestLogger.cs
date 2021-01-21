﻿using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace G2.DK.Application.MediatRRequestPipelines
{
    public class PostRequestLogger<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {
        private readonly ILogger<TRequest> _logger;

        public PostRequestLogger(ILogger<TRequest> logger)
            => _logger = logger;

        public Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;

            _logger.LogInformation("Request completed: {requestName} with response: {@response}", requestName, response);

            return Task.CompletedTask;
        }
    }
}
