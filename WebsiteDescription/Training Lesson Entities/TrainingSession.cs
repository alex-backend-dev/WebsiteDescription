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

        byte[] version = new byte[8];

        public byte[] GetVersion()
        {
            return version;
        }

        public void SetVersion(byte[] version)
        {
            
        }
    }
}
