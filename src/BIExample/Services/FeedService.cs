using System.Threading.Tasks;
using Betinvest.SDK;
using Betinvest.SDK.Objects;
using Microsoft.Extensions.Logging;
using Serilog;

namespace BIExample.Services
{
    public class FeedService
    {
        private readonly BetinvestFeedClient _client;
        private readonly bool _isLive;
        private ILogger<FeedService> _logger;
        

        public FeedService(BetinvestConfig config, BetinvestClientSingleton client, ILogger<FeedService> logger)
        {
            _logger = logger;
            _isLive = config.ServiceId == 1;
            _client = client.Instance;
        }

        public async Task Start()
        {
            _client.Ping += OnPing;
            _client.Delete += OnDelete;
            _client.Update += OnUpdate;
            _client.UpdateResult += OnUpdateResult;
            _client.Suspend += OnSuspend;
            _client.Unsuspended += OnUnsuspended;
            _client.TimerSet += OnTimerSet;
            _client.Serving += OnServing;
            _client.Score += OnScore;
            _client.UndoScore += OnUndoScore;
            _client.Cancelled += OnCancelled;
            _client.Finished += OnFinished;
            _client.MarketInsert += OnMarketInsert;
            _client.MarketDelete += OnMarketDelete;
            _client.MarketChangeOdds += OnMarketChangeOdds;
            _client.MarketSuspend += OnMarketSuspend;
            _client.MarketUnsuspend += OnMarketUnsuspend;
            _client.MarketUpdateCoef += OnMarketUpdateCoef;
            _client.OutcomeSettle += OnOutcomeSettle;
            _client.Events += OnEvents;
            _client.EventReset += ClientOnEventReset;
            _client.Auth += OnAuth;
            _client.ServiceLocked += OnServiceLocked;
            _client.ServiceUnlocked += OnServiceUnlocked;
            _client.Insert += OnInsert;
            _client.Sport += OnSport;
            _client.Category += OnCategory;
            _client.Tournament += OnTournament;
            _client.Participant += OnParticipant;
            _client.MarketTemplate += OnMarketTemplate;
            _client.ResultTypes += OnResultTypes;
            _client.Outcomes += OnOutcomes;
            _client.Scopes += OnScopes;
            _client.Announce += OnAnnounce;
            _client.MarketUpdate += OnMarketUpdate;
            _client.EventSettle += ClientOnEventSettle;

          
            await _client.Start();
        }

        private  void ClientOnEventSettle(SocketResponse<OutcomeSettle[]> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private  void ClientOnEventReset(SocketResponse<Event> data)
        {
            _logger.LogInformation(data.ToJson());
        }

     

        private void OnUpdateResult(SocketResponse<UpdateResult> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnUpdate(SocketResponse<Event> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnSport(SocketResponse<Sport[]> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnTimerSet(SocketResponse<TimerSet> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnTournament(SocketResponse<Tournament[]> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnUnsuspended(SocketResponse<EventUnsuspended> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnSuspend(SocketResponse<object> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnUndoScore(SocketResponse<UndoEventScore> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnScore(SocketResponse<EventScore> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnServing(SocketResponse<Serving> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnServiceUnlocked(SocketResponse data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnServiceLocked(SocketResponse data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnScopes(SocketResponse<Scopes[]> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnResultTypes(SocketResponse<ResultTypes[]> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnParticipant(SocketResponse<Participant[]> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnPing(SocketResponse<string> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnOutcomeSettle(SocketResponse<OutcomeSettle> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnMarketUpdateCoef(SocketResponse<MarketUpdateCoef> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnMarketUpdate(SocketResponse<MarketUpdate> data)
        {
            _logger.LogInformation(data.ToJson());
        }

        private void OnMarketTemplate(SocketResponse<MarketTemplates[]> marketunsuspend)
        {
            _logger.LogInformation(marketunsuspend.ToJson());
        }

        private void OnMarketUnsuspend(SocketResponse<MarketObject> marketunsuspend)
        {
            _logger.LogInformation(marketunsuspend.ToJson());
        }

        private void OnMarketSuspend(SocketResponse<MarketObject> marketsuspend)
        {
            _logger.LogInformation(marketsuspend.ToJson());
        }

        private void OnMarketInsert(SocketResponse<Market> marketinsert)
        {
            _logger.LogInformation(marketinsert.ToJson());
        }

        private void OnMarketDelete(SocketResponse<MarketObject> marketdelete)
        {
            _logger.LogInformation(marketdelete.ToJson());
        }

        private void OnMarketChangeOdds(SocketResponse<MarketChangeOdds> marketchangeodds)
        {
            _logger.LogInformation(marketchangeodds.ToJson());
        }

        private void OnInsert(SocketResponse<Event> eventinsert)
        {
            _logger.LogInformation(eventinsert.ToJson());
        }

        private void OnFinished(SocketResponse<SetFinished> eventfinished)
        {
            _logger.LogInformation(eventfinished.ToJson());
        }

        private void OnDelete(SocketResponse eventdelete)
        {
            _logger.LogInformation(eventdelete.ToJson());
        }

        private void OnCategory(SocketResponse<Category[]> categories)
        {
            _logger.LogInformation(categories.ToJson());
        }

        private void OnCancelled(SocketResponse setcancelled)
        {
            _logger.LogInformation(setcancelled.ToJson());
        }

        private void OnEvents(SocketResponse<Event[]> events)
        {
            _logger.LogInformation(events.ToJson());
        }

        private void OnAnnounce(SocketResponse<Event> eventannounce)
        {
            _logger.LogInformation(eventannounce.ToJson());
        }

        private void OnOutcomes(SocketResponse<OutcomeTypes[]> outcomes)
        {
            _logger.LogInformation(outcomes.ToJson());
        }

        private void OnAuth(SocketResponse auth)
        {
            if (auth.Result.ToLowerInvariant() == "ok")
            {
                _client.StartFeed().Wait();
                RequestRequirements().Wait();
            }
            else
            {
                Log.Error("Socket Client Auth Error {0}", auth.Error);
            }
        }

        private async Task RequestRequirements()
        {
            await _client.GetSport();
            await _client.GetScopes();
            await _client.GetResultTypes();
            await _client.GetOutcomes();
        }

      

       
    }
}