namespace LegendaryPetSimulator
{
    public static class LuckyBox
    {
        private static List<Rarity> data = new List<Rarity>();

        static LuckyBox()
        {
            for (var i = 0; i < 1; i++)
            {
                data.Add(Rarity.Epic);
            }

            for (var i = 0; i < 3; i++)
            {
                data.Add(Rarity.Elite);
            }

            for (var i = 0; i < 17; i++)
            {
                data.Add(Rarity.Rare);
            }

            for (var i = 0; i < 79; i++)
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
