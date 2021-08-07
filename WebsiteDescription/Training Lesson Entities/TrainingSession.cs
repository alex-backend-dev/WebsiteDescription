using System;
using System.Collections.Generic;
using WebsiteDescription.Enums;

namespace WebsiteDescription
{
	public class TrainingSession : TrainingBaseEntity, ICloneable, IVersionable
	{
		public TrainingSession(Guid id, string trainingDescription) : base(id, trainingDescription)
		{
		}

		public TrainingRecource[] TrainingRecources { get; set; }

		public LessonType GetLessonType()
		{

			foreach (var recource in TrainingRecources)
			{
				if (recource is VideoResource)
				{
					return LessonType.VideoLesson;
				}
			}

			return LessonType.TextLesson;
		}

		private readonly byte[] _version = new byte[8];

		public byte[] GetVersion()
		{
			return _version;
		}

		public void SetVersion(byte[] version)
		{
			version.CopyTo(_version, 0);
		}

		public object Clone()
		{
			var arrayResorceses = new TrainingRecource[TrainingRecources.Length];

			for (int i = 0; i < TrainingRecources.Length; i++)
			{
				var temp = (TrainingRecource)TrainingRecources[i].Clone();
				temp.Id = TrainingRecources[i].Id;
				temp.TrainingDescription = TrainingRecources[i].TrainingDescription;

				arrayResorceses[i] = temp;
			}

			return new TrainingSession(new Guid(), this.TrainingDescription)
			{
				TrainingRecources = arrayResorceses
			};
		}
	}
}
