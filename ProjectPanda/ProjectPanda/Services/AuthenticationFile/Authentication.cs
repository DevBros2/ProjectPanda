using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPanda.Services
{
    class Authentication
    {

        public interface IAuthenticate
        {
            Task<bool> Authenticate();
        }


        public static IAuthenticate Authenticator { get; private set; }


        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }
    }
}
