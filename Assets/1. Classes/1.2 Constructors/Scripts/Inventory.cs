namespace Basics
{
    [System.Serializable]
    public class Inventory 
    {
        public int Money;
        public int MedPacks;
        public int Armor;

        public Inventory(int money, int medpacks, int armor)
		{
            Money = money;
            MedPacks = medpacks;
            Armor = armor;
		}

        public bool UseMedpack()
		{
            if (MedPacks > 0)
			{
                MedPacks--;
                return true;
			}
			else
			{
                return false;
			}
		}
    }
}