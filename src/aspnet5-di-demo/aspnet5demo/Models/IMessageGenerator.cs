using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet5demo.Models
{
    public interface IMessageGenerator
    {
        string GetWelcomeMessage(string name);
    }

    public class MessageGenerator : IMessageGenerator
    {
        public string GetWelcomeMessage(string name)
        {
            return $"Hello {name}";
        }
    }
}
