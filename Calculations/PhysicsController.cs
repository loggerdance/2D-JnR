
using System;
using System.Threading;
using Elements;
using Elements.Physical;

namespace Calculations
{
	/// <summary>
	/// A PhysicsController manages the physical interactions between Entities inside a room.
	/// </summary>
	public class PhysicsController
	{
		
		public PhysicsController()
		{
			Room = new Room();
		}
		
		private Timer stepper;

		private bool running{ 
			get
			{
				return stepper != null;
			}
			set
			{
				if(value == true && stepper == null)
				{
					//all interactions should be calculated within 10 miliseconds.
					stepper = new Timer((e) => next(), null, 0, 10);
				}
				else if(value == false && stepper != null)
				{
					stepper.Dispose();
					stepper = null;
				}
			}
		}

		public Room Room
		{
			get; set;
		}
		
		public void Start()
		{
			running = true;
		}
		
		/// <summary>
		/// sets every Physical Entity into its next state.
		/// </summary>
		void next()
		{
			foreach(var entity in Room.Entities)
			{
				
				entity.Y += entity.Motion.Y;
				entity.X += entity.Motion.X;
				
				if((entity.EntityAttributes&EntityAttributes.Pinned) == EntityAttributes.Pinned)
					continue;
				entity.Motion.Y -= Room.Gravity.Y;
				entity.Motion.X -= Room.Gravity.X;
			}
		}
	}
}
