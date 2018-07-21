using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModularApplication.Features
{
    public interface IMessageProvider
    {
        Task<string> GetMessageAsync();
    }
}
