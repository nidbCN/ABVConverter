namespace ABVConverter
{
    public class Model
    {
        public string AvCode { get; set; }

        public string BvCode { get; set; }

        public void ConvertToAv() =>
            AvCode = Util.BvToAv(BvCode);

        public void ConvertToBv() =>
            BvCode = Util.AvToBv(AvCode);
    }
}
