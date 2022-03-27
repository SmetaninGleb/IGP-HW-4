
using UnityEngine;

[RequireComponent(typeof(RunFrom))]
public class RabbitMob : AMob
{
    private RunFrom runBehaviour;

    public RunFrom RunBehaviour => runBehaviour;

    public override void OnAggression(Aggressor aggressor)
    {
        aggressionVisitor.VisitOnAggression(this, aggressor);
    }

    private void Start()
    {
        runBehaviour = GetComponent<RunFrom>();
    }
}