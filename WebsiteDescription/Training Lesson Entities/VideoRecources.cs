using System;

namespace WebsiteDescription
{
	public class VideoRecources : TrainingRecources, IVersionable
	{
		private string _URIVideoContent;

		private string _URIPicture;

		private byte[] _version = new byte[8];

		public byte[] GetVersion()
		{
			return _version;
		}

		public void SetVersion(byte[] version)
		{
			version.CopyTo(_version, 0);
			//Array.Copy(version, _version, version.Length);
		}
	}
}
