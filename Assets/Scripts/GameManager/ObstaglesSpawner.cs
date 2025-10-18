using Unity.Collections;
using UnityEngine;

public class ObstaglesSpawner : MonoBehaviour
{
    
    [Header("Obstagles Spawner Settings")]
    [SerializeField] GameObject _obstaglePrefab;
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _spawnDistance;
    [SerializeField] float _spawnTime;


    private float _nextSpawnTime;
    void Update()
    {
        if (Time.time >= _nextSpawnTime)
        {
            SpawnObstagle();
            _nextSpawnTime = Time.time + 1f;
        }
    }

    private void SpawnObstagle()
    {
        Vector3 playerPosition = GameObject.FindWithTag("Player").transform.position;
        
        Vector3 spawnPosition = new Vector3(playerPosition.x, 0.5f, playerPosition.z + _spawnDistance);
        Instantiate(_obstaglePrefab, spawnPosition, Quaternion.identity);
    }





}
