namespace WebsiteDescription
{
    public interface IVersionable
    {
        public byte[] GetVersion();

        public void SetVersion(byte[] version);
    }
}
