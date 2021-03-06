using System;

using A3.Eggs;
namespace A3.Birds
{
	abstract class Bird
	{
		public static Random Rand = new Random(1);
		public abstract Egg[] LayEggs(int numEggs);
		protected Egg GetEgg(double minSize, double maxSize, double brokenChance, Egg.Colors color) 
		{
			double percent = Rand.Next(0, 101) / 100.0;
			if (percent > brokenChance)
				return new Egg(Rand.Next((int)minSize, (int)maxSize + 1), color);
			else
				return new BrokenEgg(Rand.Next((int)minSize, (int)maxSize + 1), color);
		}
	}

	class Chicken : Bird
	{
        public override Egg[] LayEggs(int numEggs)
        {
			Egg[] eggs = new Egg[numEggs];

			for(int i = 0; i < eggs.Length; i++)
            {
				eggs[i] = GetEgg(2, 4, 0.25, Egg.Colors.brown);
            }

			return eggs;
        }
    }

	class Ostrich : Bird
	{
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] eggs = new Egg[numEggs];

			for (int i = 0; i < eggs.Length; i++)
			{
				eggs[i] = GetEgg(10, 15, 0.45, Egg.Colors.speckled);
			}

			return eggs;
		}
	}
}
