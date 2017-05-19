using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood
{

    public interface IGreeter
    {
        string GetGreeting();
    }

    public class Greeter : IGreeter
    {
        private string _greeting;
        private int _nothing;

        public Greeter(IConfiguration configuration)
        {
            _greeting = configuration["Greeting"];
            _nothing = 0;
        }

        public string GetGreeting()
        {
            return _greeting;
        }
    }
}