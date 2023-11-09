using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

namespace General
{
    public class InstantiateGhostObjs : MonoBehaviour
    {
        private readonly float timeToDestroy = 5f;

        [Header("Configuration")]
        [SerializeField] private GameObject ghosts;
        [SerializeField] private float timeBetweenSpawn;
        [SerializeField] private Transform leftPos;
        [SerializeField] private Transform rigthPos;


        private void Start()
        {
            StartCoroutine(SpawnGhost());
        }

        private void InstantiateGhost()
        {
            GameObject ghost = Instantiate(ghosts, RandomPos(), quaternion.identity);
            Destroy(ghost, timeToDestroy);
        }

        private Vector3 RandomPos()
        {
            Vector3 randomPosition = Vector3.Lerp(leftPos.position, rigthPos.position, Random.value);
            return randomPosition;
        }

        IEnumerator SpawnGhost()
        {
            while (true)
            {
                InstantiateGhost();
                yield return new WaitForSeconds(timeBetweenSpawn);
            }
        }

    }
}
