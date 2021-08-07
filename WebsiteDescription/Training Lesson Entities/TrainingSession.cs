using WebsiteDescription.Enums;

namespace WebsiteDescription
{
    public class TrainingSession : TrainingBaseEntity, ICloneable, IVersionable
    {
        TrainingRecources[] trainingRecources { get; set; }

        public LessonType GetLessonType()
        {

            foreach (var recource in trainingRecources)
            {
                if (recource is VideoRecources)
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
	        throw new System.NotImplementedException();
        }
    }
}
