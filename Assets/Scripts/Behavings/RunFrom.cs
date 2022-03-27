using UnityEngine;

public class RunFrom : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private bool _isRunning = false;
    private Transform _runFrom;

    private void Update()
    {
        if (_isRunning) Run();
    }

    private void Run()
    {
        transform.position += (transform.position - _runFrom.position).normalized * _speed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(transform.position - _runFrom.position);
    }

    public void StartRunning(Transform from)
    {
        _isRunning = true;
        _runFrom = from;
    }
}