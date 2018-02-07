using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace HereAreTheClothesYouWant.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;

        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }

        public void sendMessage(string to, string subject, string address)
        {
            _logger.LogInformation($"To: {to} Subject: {subject} Address: {address}");
        }
    }
}
