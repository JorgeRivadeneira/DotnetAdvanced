using DesignPatternASP.Models.ViewModels;
using DesignPatterns.Repository;

namespace DesignPatternASP.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;

        public IBeerStrategy Strategy
        {
            set { _strategy = value; }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerViewModel, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerViewModel, unitOfWork);
        }
    }
}
