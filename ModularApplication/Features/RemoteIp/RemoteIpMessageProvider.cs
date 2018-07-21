using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModularApplication.Features.RemoteIp
{
    public class RemoteIpMessageProvider : IMessageProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RemoteIpMessageProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<string> GetMessageAsync()
        {
            var remoteIpAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress;
            return Task.FromResult($"Your IP address: {remoteIpAddress}");
        }
    }
}
