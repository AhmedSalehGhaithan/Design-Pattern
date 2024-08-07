using MediatorDesignPattern.ChatRoomProject;
using MediatorDesignPattern.ControlTowerProject;
using MediatorDesignPattern.FacebookGroupProject;
using MediatorDesignPattern.JobPortalProject;
using MediatorDesignPattern.OnlineAuctionSystem;
using MediatorDesignPattern.SmartHomeSystem;
using MediatorDesignPattern.StockExchangeProject;
using MediatorDesignPattern.TaxiDispatchSystem;
using MediatorDesignPattern.UIFramework;
using System;
namespace MediatorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobPortalProject();
            Console.ReadKey();
        }
        static void JobPortalProject()
        {
            var jobPortal = new JobPortal();
            var employer = new Employer("TechCorp", jobPortal);
            var jobSeeker = new JobSeeker("John", jobPortal);
            employer.PostJob("Software Engineer");
            jobSeeker.Apply("Software Engineer");
        }
        static void OnlineAuctionSystem()
        {
            var auction = new Auction();
            var bidderJohn = new Bidder("John");
            var bidderJane = new Bidder("Jane");
            auction.RegisterBidder(bidderJohn);
            auction.RegisterBidder(bidderJane);
            auction.StartAuction(100);
            bidderJohn.Bid(120);
            bidderJane.Bid(130);
            bidderJohn.Bid(140);
            auction.CloseAuction();
        }
        static void StockExchangeProject()
        {
            var stockExchange = new StockExchange();
            var traderBob = new Trader("Bob", stockExchange);
            var traderAlice = new Trader("Alice", stockExchange);
            traderBob.PlaceOrder("AAPL", 100, OrderType.Buy);
            traderAlice.PlaceOrder("AAPL", 100, OrderType.Sell);
        }
        static void TaxiDispatchSystem()
        {
            var dispatch = new TaxiDispatch();
            var driverJohn = new Driver("John");
            dispatch.RegisterDriver(driverJohn);
            var passengerAlice = new Passenger("Alice", dispatch);
            passengerAlice.RequestRide("Central Park");
        }
        static void UIFramework()
        {
            // Usage
            var uiController = new UIController();
            var dropdown = new Dropdown(uiController);
            var textField = new TextField(uiController);
            dropdown.SelectOption("option1");  // This should notify the UI controller to display additional text fields
        }
        static void SmartHomeSystem()
        {
            // Usage
            var homeController = new HomeController();
            var window = new Window(homeController);
            var heater = new Heater(homeController);
            window.Open();  // This should notify the controller to turn off heater and lights
            heater.TurnOn();
        }
        static void ChatRoomProject()
        {
            var chatroom = new ChatRoom();

            var Ahmed = new Participant("Ahmed");
            var Ali = new Participant("Ali");

            chatroom.Register(Ahmed);
            chatroom.Register(Ali);

            Ahmed.Send("Ali", "Hey there!");
            Ali.Send("Ahmed", "Hi Ahmed!");
        }
        static void ControlTowerProject()
        {
            IControlTower controlTower = new ControlTower();

            controlTower.RegisterRunway(new Runway("R1"));
            controlTower.RegisterRunway(new Runway("R2"));

            var airplane1 = new Airplane("FL123", controlTower);
            var airplane2 = new Airplane("FL456", controlTower);
            var airplane3 = new Airplane("FL478", controlTower);

            airplane1.RequestLanding();
            airplane2.RequestLanding();
            airplane3.RequestLanding();
            // Only one plane should land as we only have one runway. 
            // The other should wait for an available runway.
        }
        static void FacebookGroupProject()
        {
            IFacebookGroupMediator facebookGroupMediator = new ConcreteFacebookGroupMediator();

            //Create instances of Colleague i.e. Creating users
            Users Ram    = new ConcreteUser("Ram");
            Users Dave   = new ConcreteUser("Dave");
            Users Smith  = new ConcreteUser("Smith");
            Users Rajesh = new ConcreteUser("Rajesh");
            Users Sam    = new ConcreteUser("Sam");
            Users Pam    = new ConcreteUser("Pam");
            Users Anurag = new ConcreteUser("Anurag");
            Users John   = new ConcreteUser("John");

            //Registering the users with the Mediator i.e. Facebook Group
            facebookGroupMediator.RegisterUser(Ram);
            facebookGroupMediator.RegisterUser(Dave);
            facebookGroupMediator.RegisterUser(Smith);
            facebookGroupMediator.RegisterUser(Rajesh);
            facebookGroupMediator.RegisterUser(Sam);
            facebookGroupMediator.RegisterUser(Pam);
            facebookGroupMediator.RegisterUser(Anurag);
            facebookGroupMediator.RegisterUser(John);

            //One of the users Sending one Message in the Facebook Group
            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();

            //Another user Sending another Message in the Facebook Group
            Rajesh.Send("What is Design Patterns? Please explain ");

        }
    }
}
