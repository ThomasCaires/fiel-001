using FielApi.core.entities;

namespace FielApi.core.usecases
{
    public class AddPointCaseImpl : IAddPointsCase
    {
        public void AddPoints(Buyer buyer)
        {
            buyer.Points += buyer.Tier.AddedPoint;
        }
    }
}
