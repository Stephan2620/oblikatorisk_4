using System.Collections.Generic;

namespace RESTBeer.manager
{
    public class BeerManager
    {
        private static int _nextId = 1;

        private static readonly List<Beer.Beer> BeerData = new List<Beer.Beer>
        {
            new Beer.Beer {Id = _nextId++, Name = "Øller1", Price = 12, Abv = 5},
            new Beer.Beer {Id = _nextId++, Name = "Øller2", Price = 13, Abv = 6},
            new Beer.Beer {Id = _nextId++, Name = "Øller3", Price = 14, Abv = 7}
        };

        public List<Beer.Beer> getAll()
        {
            return BeerData;
        }

        public Beer.Beer GetById(int id)
        {
            return BeerData.Find(beer => beer.Id == id);
        }

        public Beer.Beer Add(Beer.Beer newBeer)
        {
            newBeer.Id = _nextId++;
            BeerData.Add(newBeer);
            return newBeer;
        }

        public Beer.Beer Delete(int id)
        {
            var beer = BeerData.Find(beer1 => beer1.Id == id);
            if (beer == null) return null;
            BeerData.Remove(beer);
            return beer;
        }

        public Beer.Beer Update(int id, Beer.Beer updates)
        {
            var Beer = BeerData.Find(beer1 => beer1.Id == id);
            if (Beer == null) return null;
            Beer.Name = updates.Name;
            Beer.Price = updates.Price;
            Beer.Abv = updates.Abv;
            return Beer;
        }
    }
}