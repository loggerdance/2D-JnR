using System;

namespace Elements.Physical
{
	/// <summary>
	/// Everything that you can see, touch or hear*.
	/// </summary>
	public abstract class Entity
	{
		public Entity()
		{
			
		}
		public double X
		{
			get; set;
		}
		public double Y
		{
			get; set;
		}
		public double Height
		{
			get; set;
		}
		public double Width
		{
			get; set;
		}
	}
}
