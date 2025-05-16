namespace FielApi.core.constants
{
    public record TierRecord(int TierNumber,  float AddedPoint)
    {
        public static TierRecord Category01{ get; } = new (1, 1.1f);
        public static TierRecord Category02{ get; } = new (2, 1.30f);
        public static TierRecord Category03{ get; } = new (3, 1.50f);
        public static TierRecord Category04{ get; } = new (4, 1.50f);




    }
}
