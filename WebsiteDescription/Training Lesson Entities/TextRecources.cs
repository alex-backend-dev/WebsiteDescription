namespace WebsiteDescription
{
    public class TextRecources : TrainingRecources
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
    }
}
