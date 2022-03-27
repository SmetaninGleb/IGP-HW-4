using System.Collections.Generic;
using UnityEngine;

abstract public class AMob : MonoBehaviour
{
    protected IOnAggressionMobVisitor aggressionVisitor = new OnAggressionMobVisitor();

    abstract public void OnAggression(Aggressor aggressor);
}
