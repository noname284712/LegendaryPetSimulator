namespace LegendaryPetSimulator
{
    public static class LuckyBox
    {
        private static List<Rarity> data = new List<Rarity>();

        static LuckyBox()
        {
            for (var i = 0; i < 8; ++i)
            {
                data.Add(Rarity.Epic);
            }

            for (var i = 0; i < 8; ++i)
            {
                data.Add(Rarity.Elite);
            }

            for (var i = 0; i < 8; ++i)
            {
                data.Add(Rarity.Rare);
            }

            for (var i = 0; i < 10; ++i)
            {
                data.Add(Rarity.Uncommon);
            }
        }

        public static Rarity Pick()
        {
            var index = Random.Shared.Next(0, data.Count);
            return data[index];
        }
    }
}
