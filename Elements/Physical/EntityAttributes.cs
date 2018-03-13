
using System;

namespace Elements.Physical
{
	/// <summary>
	/// Description of PhysicalBehavior.
	/// </summary>
	[Flags]
	public enum EntityAttributes
	{
		/// <summary>
		/// Initial value for Entities
		/// </summary>
		None = 0,
		/// <summary>
		/// Solid objects do not pass through other solid objects.
		/// </summary>
		Solid = 1,
		/// <summary>
		/// Pinned objects don't fall down.
		/// </summary>
		Pinned = 2,
		
	}
}
