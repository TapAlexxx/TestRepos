using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : ObjectPool 
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _maxTimeBetweenSpawn;
    [SerializeField] private float _minTimeBetweenSpawn;

    private float _delayBetweenSpawn;
    private float _elapsedTime = 0;

    private void Start()
    {
        _delayBetweenSpawn = Random.Range(_minTimeBetweenSpawn, _maxTimeBetweenSpawn);
        Initialize(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _delayBetweenSpawn)
        {
            if (TryGetObject(out GameObject gameObject))
            {
                _elapsedTime = 0;

                gameObject.SetActive(true);
                gameObject.transform.position = _spawnPoint.position;

                _delayBetweenSpawn = Random.Range(_minTimeBetweenSpawn, _maxTimeBetweenSpawn);

                DisableUnvisibleObjects();
            }
        }
    }
}
