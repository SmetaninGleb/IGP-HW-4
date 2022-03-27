
using System;

public class OnAggressionMobVisitor : IOnAggressionMobVisitor
{
    public void VisitOnAggression(RabbitMob rabbit, Aggressor aggressor)
    {
        // Run from aggressor
        rabbit.RunBehaviour.StartRunning(aggressor.transform);
    }

    public void VisitOnAggression(WolfMob wolf, Aggressor aggressor)
    {
        // Attack aggressor
        if (wolf.AggerssorBehaviour.IsAggressive) return;
        wolf.AggerssorBehaviour.BecomeAggressive(aggressor.transform);
    }

    public void VisitOnAggression(AMob abstractMob, Aggressor aggressor)
    {
        throw new Exception("Visit function not added!");
    }
}