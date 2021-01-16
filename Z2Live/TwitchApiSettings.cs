using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitchLib.Client.Models;

namespace Z2Live
{
    public class TwitchApiSettings
    {
        private ConnectionCredentials _credentials;
        public string Username { get; set; }
        public string ClientId { get; set; }
        public string AccessToken { get; set; }

    }
}
