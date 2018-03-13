
using System;
using System.Threading;
using System.Threading.Tasks;
using Calculations;
using Elements;
using Elements.Physical;

namespace Test
{
	class Program
	{
		public static void Main(string[] args)
		{
			PhysicsController test = new PhysicsController();
			Entity myApple = new PresentableObject()
			{
				X = 100,
				Y = 100,
				Width = 2, 
				Height = 2,
				Motion = new Vector()
				{
					X = 0,
					Y = 10
				},
				EntityAttributes = EntityAttributes.Solid
			};
			
			test.Room.Entities.Add(myApple);
			
			test.Start();
			new Task(
				() =>
		         {
					while(true)
					{
						Console.WriteLine(myApple.Y);
						Thread.Sleep(5);
					}
		         }
			).Start();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}