namespace ABVConverter
{
    public class Model
    {
        private string _bvCode;
        private string _avCode;

        public string AvCode
        {
            get => _avCode;
            set => _avCode = value;
        }

        public string BvCode
        {
            get => _bvCode;
            set
            {
                _bvCode = value;
            }
        }

        public void ConvertToAv() =>
            AvCode = Util.BvToAv(BvCode);

        public void ConvertToBv() =>
            BvCode = Util.AvToBv(AvCode);
    }
}
