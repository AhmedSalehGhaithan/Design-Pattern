namespace MediatorDesignPattern.OnlineAuctionSystem
{
    // Mediator
    public interface IAuctionMediator
    {
        void PlaceBid(Bidder bidder, decimal amount);
        void RegisterBidder(Bidder bidder);
        void StartAuction(decimal startPrice);
        void CloseAuction();
    }
}
