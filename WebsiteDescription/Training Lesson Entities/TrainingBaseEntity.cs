using System;

namespace WebsiteDescription
{
    public abstract class TrainingBaseEntity
    {
        public Guid Id { get; set; }

        private readonly int TEXT_LIMIT = 256;

        private string _trainingDescription;

        protected TrainingBaseEntity(Guid id, string trainingDescription)
        {
	        Id = id;
	        TrainingDescription = trainingDescription;
        }

        public string TrainingDescription
        {
            get
            {
                return _trainingDescription;
            }
            set
            {
                if (value.Length <= TEXT_LIMIT)
                {
                    _trainingDescription = value;
                }
            }
        }

        public override string ToString()
        {
            return TrainingDescription;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
       
            TrainingBaseEntity uniqueIdentificator = obj as TrainingBaseEntity; 

            if (uniqueIdentificator as TrainingBaseEntity == null)
                return false;

            return Id == uniqueIdentificator.Id;
        }
    } 
}
