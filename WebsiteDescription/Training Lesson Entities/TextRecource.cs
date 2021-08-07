using System;

namespace WebsiteDescription
{
    public class TextRecource : TrainingRecource
    {
        private readonly int TEXT_LIMIT = 10000;

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                if (value.Length <= TEXT_LIMIT)
                {
                    _text = value;
                }
            }
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public TextRecource(Guid id, string trainingDescription) : base(id, trainingDescription)
        {
        }
    }
}
