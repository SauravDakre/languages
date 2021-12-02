namespace TryClass
{
    class TryIndexer
    {
        public readonly Dictionary<string, string>
            _dict = new Dictionary<string, string>();

        public string this[string key]
        {
            get
            {
                return this._dict[key];
            }
            set
            {
                this._dict[key] = value;
            }
        }
    }
}
