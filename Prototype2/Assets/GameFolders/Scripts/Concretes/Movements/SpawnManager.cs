using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Prototype2.MoveForward
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] GameObject[] _animalPrefabs;
        private float _spawnRangeX = 15;
        private float _spawnPosZ = 20;
        private float _startDelay = 2; 
        private float _spawnInterval = 1.5f;


        private void Start()
        {
            InvokeRepeating("SpawnRandomAnimal", _startDelay, _spawnInterval);
        }
        void Update()
        {
           
        }

        private void SpawnRandomAnimal()
        {
            int _animalIndex = Random.Range(0, _animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnPosZ);
            Instantiate(_animalPrefabs[_animalIndex], spawnPos, _animalPrefabs[_animalIndex].transform.rotation);
        }
    }
}

