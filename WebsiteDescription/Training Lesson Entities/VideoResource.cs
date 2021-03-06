using System;

namespace WebsiteDescription
{
	public class VideoRecource : TrainingRecource, IVersionable
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

		public override object Clone()
		{
			var vr = new VideoRecource(this.Id, this.TrainingDescription);

			var version = new byte[8];
			_version.CopyTo(version, 0);

			vr.SetVersion(version);

			return vr;
		}

		public VideoRecource(Guid id, string trainingDescription) : base(id, trainingDescription)
		{
		}
	}
}
