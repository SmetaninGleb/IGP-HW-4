using System.Collections.Generic;
using UnityEngine;

public class MobsFactory : MonoBehaviour
{
    [SerializeField] private List<MobSpawnPoint> _mobSpawnPoints;

    protected static List<AMob> _allMobsList = new List<AMob>();

    public static IReadOnlyList<AMob> AllMobsList => _allMobsList;

    private void Start()
    {
        foreach (MobSpawnPoint point in _mobSpawnPoints)
        {
            AMob mob = Instantiate(point.PrefabToSpawn, point.transform.position, point.transform.rotation);
            _allMobsList.Add(mob);
        }
    }
}