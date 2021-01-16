using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitchLib.Api;
using TwitchLib.Api.Helix.Models.Streams;

namespace Z2Live.Hubs
{
    public class StreamHub : Hub
    {
        private TwitchAPI _api;
        private const string GameName = "Zelda II: The Adventure of Link";
        private const string DefaultUrl = "none";
        private Random random;

        
        public StreamHub(IOptionsMonitor<TwitchApiSettings> config)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));

            _api = new TwitchAPI();
            _api.Settings.ClientId = config.CurrentValue.ClientId;
            _api.Settings.AccessToken = config.CurrentValue.AccessToken;
            random = new Random();
        }

        public async Task TargetUrlRequest()
        {
            var url = DefaultUrl;
            try
            {
                var game = _api.Helix.Games.GetGamesAsync(null, new List<string>() { GameName }).Result;
                var gameList = game.Games.Select(g => g.Id).ToList();

                var streams = _api.Helix.Streams.GetStreamsAsync(null, null, 20, gameList).Result;
                
                if (streams.Streams.Length > 1)
                {
                    url = $"https://twitch.tv/{streams.Streams[random.Next(0,streams.Streams.Length - 1)].UserName}";
                }
                else if (streams.Streams.Length == 1)
                {
                    url = $"https://twitch.tv/{streams.Streams[0].UserName}";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            await Clients.Caller.SendAsync("TargetUrlResponse", url);
        }
    }
}
