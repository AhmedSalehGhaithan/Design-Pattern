using System.Collections.Generic;
using System;

namespace MediatorDesignPattern.OnlineAuctionSystem
{
    public class Auction : IAuctionMediator
    {
        private decimal _currentPrice;
        private Bidder _highestBidder;
        private List<Bidder> _bidders = new List<Bidder>();
        public void RegisterBidder(Bidder bidder)
        {
            _bidders.Add(bidder);
            bidder.JoinAuction(this);
        }
        public void StartAuction(decimal startPrice)
        {
            _currentPrice = startPrice;
            Console.WriteLine($"Auction started at price: {startPrice}");
        }
        public void PlaceBid(Bidder bidder, decimal amount)
        {
            if (amount > _currentPrice)
            {
                _currentPrice = amount;
                _highestBidder = bidder;
                Console.WriteLine($"{bidder.Name} is the highest bidder with {amount}!");
            }
            else
            {
                Console.WriteLine($"{bidder.Name}'s bid of {amount} is below the current highest bid.");
            }
        }
        public void CloseAuction()
        {
            Console.WriteLine($"Auction closed! {_highestBidder.Name} wins with a bid of {_currentPrice}!");
        }
    }
}
