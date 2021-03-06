﻿
namespace RPGGame.Items
{
    class Beer : Item
    {
        private const char BeerSymbol = 'B';
        public Beer(Position position, BeerSize beerSize)
            : base(position, BeerSymbol)
        {
            this.BeerSize = beerSize;
            
        }
        private BeerSize BeerSize { get; set; }

        public int HealthRestore
        { 
            get { return (int)this.BeerSize; } 
        }
        
    }
}
