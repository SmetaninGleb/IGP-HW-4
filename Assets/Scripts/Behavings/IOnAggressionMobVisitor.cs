
public interface IOnAggressionMobVisitor
{
    public void VisitOnAggression(RabbitMob rabbit, Aggressor aggressor);
    public void VisitOnAggression(WolfMob wolf, Aggressor aggressor);
    public void VisitOnAggression(AMob abstractMob, Aggressor aggressor);
}