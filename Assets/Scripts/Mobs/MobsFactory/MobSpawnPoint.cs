using UnityEngine;

public class MobSpawnPoint : MonoBehaviour
{
    [SerializeField] private AMob _prefabToSpawn;

    public AMob PrefabToSpawn => _prefabToSpawn;
}