using Microsoft.Extensions.Logging;

namespace AppCommon.Exceptions
{
    public class NoResultException : Exception
    {
        public string? UserKey { get; private set; }
        public int AuctionId { get; private set; }
        public int NftProductId { get; private set; }
        public NoResultException(ILogger? logger, string? userKey = null, int auctionId = 0, int nftProductId = 0)
        {
            UserKey = userKey;
            AuctionId = auctionId;
            NftProductId = nftProductId;

            if (logger != null)
                logger.LogError(this, null, userKey, auctionId, NftProductId);
        }

        public NoResultException()
        {
        }
    }
}
