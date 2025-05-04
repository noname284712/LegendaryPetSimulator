namespace LegendaryPetSimulator
{
    public class Inventory
    {
        private readonly Dictionary<Rarity, int> data = new Dictionary<Rarity, int>();

        public Inventory()
        {
            this.data[Rarity.Uncommon] = 0;
            this.data[Rarity.Rare] = 0;
            this.data[Rarity.Elite] = 0;
            this.data[Rarity.Epic] = 0;
            this.data[Rarity.Legendary] = 0;
        }

        public void Add(Rarity rarity)
        {
            if (!this.data.ContainsKey(rarity))
            {
                this.data[rarity] = 0;
            }
            this.data[rarity]++;
        }

        public bool HasLegendary()
        {
            return this.data[Rarity.Legendary] > 0;
        }

        public void RarityUp()
        {
            while (this.data[Rarity.Uncommon] >= 3)
            {
                this.data[Rarity.Uncommon] -= 2;
                if (Random.Shared.NextDouble() < 0.3)
                {
                    this.data[Rarity.Rare]++;
                }
            }

            while (this.data[Rarity.Rare] >= 3)
            {
                this.data[Rarity.Rare] -= 2;
                if (Random.Shared.NextDouble() < 0.3)
                {
                    this.data[Rarity.Elite]++;
                }
            }

            while (this.data[Rarity.Elite] >= 3)
            {
                this.data[Rarity.Elite] -= 2;
                if (Random.Shared.NextDouble() < 0.25)
                {
                    this.data[Rarity.Epic]++;
                }
            }

            if (this.data[Rarity.Epic] >= 3)
            {
                this.data[Rarity.Epic] -= 2;
                if (Random.Shared.NextDouble() < 0.2)
                {
                    this.data[Rarity.Legendary]++;
                }
            }
        }
    }
}
