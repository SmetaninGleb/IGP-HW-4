using UnityEngine;

[RequireComponent(typeof(Aggressor))]
public class LookingForAggression : MonoBehaviour
{
    [SerializeField] private float _lookingDistance = 6f;
    private Aggressor _aggressor;
    private bool _isLooking = true;

    private void Start()
    {
        _aggressor = GetComponent<Aggressor>();
    }

    private void Update()
    {
        if (!_isLooking) return;
        foreach (AMob mob in MobsFactory.AllMobsList)
        {
            if (mob == this) continue;
            if (Vector3.Distance(mob.transform.position, transform.position) <= _lookingDistance)
            {
                _isLooking = false;
                _aggressor.BecomeAggressive(mob.transform);
                break;
            }
        }
    }
}