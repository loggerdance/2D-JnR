
using System;
using System.Collections.Generic;
using Elements.Physical;

namespace Elements
{
	/// <summary>
	/// A room is a space, where Physical Interaction is calculated.
	/// </summary>
	public class Room
	{
		public Room()
		{
			entities = new List<Entity>();
			Gravity = new Vector( 0, 0.091);
		}
		
		private List<Entity> entities;

		/// <summary>
		/// All entities in this room.
		/// </summary>
		public List<Entity> Entities
		{
			get {
				return entities;
			}
			set {
				entities = value;
			}
		}

		public Vector Gravity
		{
			get; set;
		}
		
	}
}
