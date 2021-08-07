using System;

namespace WebsiteDescription
{
	public abstract class TrainingRecource : TrainingBaseEntity, ICloneable
	{
		public abstract object Clone();

		protected TrainingRecource(Guid id, string trainingDescription) : base(id, trainingDescription)
		{
		}
	}
}
