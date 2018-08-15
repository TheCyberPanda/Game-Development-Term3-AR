using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavespawner : MonoBehaviour
{
    [SerializeField] private float _timeBetweenWaves;
    [SerializeField] private int _amountOfEnemiesToSpawn;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _amountOfWavesToWin;

    [SerializeField] private Enemy _enemyToSpawn;
    [SerializeField] private Canvas _victoryCanvas;

    private float _currentCountDown;
    private int _waveNumber = 0;

    private void Awake()
    {
        _currentCountDown = _timeBetweenWaves;
    }

    private void Update()
    {
        _currentCountDown -= Time.deltaTime;

        if (_currentCountDown <= 0)
        {
            _currentCountDown = _timeBetweenWaves;
            _waveNumber++;
            for (int i = 0; i < _amountOfEnemiesToSpawn; i++)
            {
                var enemy = Instantiate(_enemyToSpawn);
                var pos = _spawnPoints[Random.Range(0, _spawnPoints.Length)];
                enemy.transform.position = pos.transform.position;
                
                
            }
        }
        
        //Will be refactored into a game manager.
        if (_waveNumber > _amountOfWavesToWin)
        {
            _victoryCanvas.gameObject.SetActive(true);
        }
    }
}