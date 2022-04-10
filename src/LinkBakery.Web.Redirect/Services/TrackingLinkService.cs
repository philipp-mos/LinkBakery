// using LinkBakery.Core.Models;
// using LinkBakery.Core.Repositories.Interfaces;
using LinkBakery.Web.Redirect.Services.Interfaces;

namespace LinkBakery.Web.Redirect.Services
{
    public class TrackingLinkService // : Core.Services.TrackingLinkService, ITrackingLinkService
    {/*
        public TrackingLinkService(
            ITrackingLinkRepository trackingLinkRepository,
            ITrackingLinkCallRepository trackingLinkCallRepository)
            : base(trackingLinkRepository, trackingLinkCallRepository)
        { }

        
        public string? GetLinkAndTrackCall(string key, string? queryString = null)
        {
            var trackingLink = _trackingLinkRepository.FindActiveByKey(key);

            if (trackingLink == null)
            {
                return null;
            }

            SaveLinkTrackingCall(trackingLink, queryString);

            if (trackingLink.RedirectWithQueryParameter && !string.IsNullOrEmpty(queryString))
            {
                return $"{ trackingLink.TargetUrl }{ queryString }";
            }

            return trackingLink.TargetUrl;
        }




        private void SaveLinkTrackingCall(TrackingLink trackingLink, string? queryString)
        {
            var trackingLinkCall = new TrackingLinkCall
            {
                DateTime = DateTime.Now,
                TrackingLinkId = trackingLink.Id
            };

            if (trackingLink.RedirectWithQueryParameter && !string.IsNullOrEmpty(queryString))
            {
                trackingLinkCall.QueryParameter = queryString;
            }

            _trackingLinkCallRepository.InsertAndSafeAsync(trackingLinkCall);
        }
        */
    }
}
