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
			EntityAttributes = EntityAttributes.None;
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
		public Vector Motion
		{ 
			get; set;
		}
		public EntityAttributes EntityAttributes 
		{
			get; set;
		}
	}
}
