using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour
{

    public GameObject[] dummies;

    public float minSpawnRate = 10;
    public float maxSpawnRate = 20;
    public float rMax = 20;

    private float angleDeg;

    private float r;

    private float timeToSpawnNext = 10;

    private float timeSinceLastSpawnw = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            timeSinceLastSpawnw += Time.deltaTime;

            if (timeSinceLastSpawnw > timeToSpawnNext)
                spawn();
    }

    private void spawn()
    {
        angleDeg = Random.Range(0, 360);
        r = Random.Range(0, rMax);

        float x = r * Mathf.Cos(angleDeg);
        float z = r * Mathf.Sin(angleDeg);

        int objectIndex = Random.Range(0, dummies.Length);
        GameObject.Instantiate(dummies[objectIndex], new Vector3(x, dummies[objectIndex].transform.position.y, z), Quaternion.identity);

        timeToSpawnNext = Random.Range(minSpawnRate, maxSpawnRate);

        timeSinceLastSpawnw = 0;
    }
}