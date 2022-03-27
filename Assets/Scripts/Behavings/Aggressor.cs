using UnityEngine;

public class Aggressor : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private bool _isAggressive = false;
    private Transform _runTo;

    public bool IsAggressive => _isAggressive;

    private void Update()
    {
        if (_isAggressive) RunTo();
    }

    private void RunTo()
    {
        transform.position += (_runTo.transform.position - transform.position).normalized * _speed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(_runTo.transform.position - transform.position);
    }

    public void BecomeAggressive(Transform victimTransform)
    {
        if (victimTransform.TryGetComponent(out AMob victimMob))
        {
            victimMob.OnAggression(this);
        }
        _isAggressive = true;
        _runTo = victimTransform;
    }
}
