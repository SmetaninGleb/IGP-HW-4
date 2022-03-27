
using UnityEngine;

[RequireComponent(typeof(Aggressor))]
[RequireComponent(typeof(LookingForAggression))]
public class WolfMob : AMob
{
    private Aggressor _aggressorBehaviour;

    public Aggressor AggerssorBehaviour => _aggressorBehaviour;

    public override void OnAggression(Aggressor aggressor)
    {
        aggressionVisitor.VisitOnAggression(this, aggressor);
    }
    private void Start()
    {
        _aggressorBehaviour = GetComponent<Aggressor>();
    }
}