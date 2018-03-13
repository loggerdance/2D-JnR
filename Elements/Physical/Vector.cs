
using System;

namespace Elements.Physical
{
	/// <summary>
	/// A Vector.
	/// (Forces an Entity to move into a direction, for example.)
	/// </summary>
	public class Vector
	{
		public Vector()
		{
			
		}
		
		public Vector(double x, double y)
		{
			Y = y;
			X = x;
		}
		
		public double X
		{
			get; set;
		}
		public double Y
		{
			get; set;
		}
	}
}
