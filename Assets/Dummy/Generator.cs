using UnityEngine;
using System.Collections;

namespace Triad.Enemies
{
    public class Generator : MonoBehaviour
    {

        public GameObject[] dummies;

        public float minSpawnRate = 10;
        public float maxSpawnRate = 20;
        public float rMax = 20;
        public int initialCount = 20;

        private float angleDeg;

        private float r;

        private float timeToSpawnNext;

        private float timeSinceLastSpawnw = 0;

        private void Awake()
        {
            timeToSpawnNext = minSpawnRate;
        }

        private void Start()
        {
            for (int i = 0; i < initialCount; i++)
            {
                Spawn();
            }
        }

        // Update is called once per frame
        void Update()
        {
            timeSinceLastSpawnw += Time.deltaTime;

            if (timeSinceLastSpawnw > timeToSpawnNext)
                Spawn();
        }

        private void Spawn()
        {
            angleDeg = Random.Range(0, 360);
            r = Random.Range(0, rMax);

            float x = r * Mathf.Cos(angleDeg);
            float z = r * Mathf.Sin(angleDeg);

            int objectIndex = Random.Range(0, dummies.Length);
            GameObject.Instantiate(dummies[objectIndex], transform.position + new Vector3(x, dummies[objectIndex].transform.position.y, z), Quaternion.identity);

            timeToSpawnNext = Random.Range(minSpawnRate, maxSpawnRate);

            timeSinceLastSpawnw = 0;
        }

        private void OnDrawGizmos()
        {
            //Gizmos.color = Color.yellow;
            //Gizmos.DrawSphere(transform.position, rMax);
        }
    }
}