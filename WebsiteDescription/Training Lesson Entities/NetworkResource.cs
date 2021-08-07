using System;

namespace WebsiteDescription
{
    public class NetworkResource : TrainingRecource 
    {
        private string _URIContent;
        public override object Clone()
        {
	        return this.MemberwiseClone();
        }

        public NetworkResource(Guid id, string trainingDescription) : base(id, trainingDescription)
        {
        }
    }
}
