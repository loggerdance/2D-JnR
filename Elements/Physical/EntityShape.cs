
using System;

namespace Elements.Physical
{
	/// <summary>
	/// This defines an abstract hitbox.
	/// 
	/// INFO: collisions will be detected by first checking the Y-boundaries, then checking shape-collisions
	/// </summary>
	public abstract class EntityShape
	{
		private Entity boundEntity;
		public EntityShape(Entity boundEntity)
		{
			this.boundEntity = boundEntity;
		}

		public Entity BoundEntity {
			get {
				return boundEntity;
			}
			set {
				boundEntity = value;
			}
		}
		
		public abstract bool Collides(EntityShape other, double offset);
		public abstract bool IsCollided(EntityShape other, double offset);
	}
}
