namespace MediatorDesignPattern.OnlineAuctionSystem
{
    // Colleague
    public class Bidder
    {
        public string Name { get; private set; }
        private IAuctionMediator _auction;
        public Bidder(string name)
        {
            Name = name;
        }
        public void JoinAuction(IAuctionMediator auction)
        {
            _auction = auction;
        }
        public void Bid(decimal amount)
        {
            _auction.PlaceBid(this, amount);
        }
    }
}
