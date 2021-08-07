namespace WebsiteDescription
{
    public class VideoRecources : TrainingRecources, IVersionable
    {
        private string _URIVideoContent;

        private string _URIPicture;

        byte[] version = new byte[8];

        public byte[] GetVersion()
        {
            return version;
        }

        public void SetVersion(byte[] version)
        {
            // новый массив (копирование массива из одного массива в другой WriteCopy) * не через foreach
        }
    }
}
