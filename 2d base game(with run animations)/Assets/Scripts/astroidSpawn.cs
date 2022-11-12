using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidSpawn : MonoBehaviour
{
    public GameObject spawnedPrefab;
    public BoxCollider2D spawnArea;

    float lastSpawnTimeS = -1;
    public float spawnDelayS = 3;

    // Use this for initialization
    void Start()
    {
        spawnArea = GetComponent<BoxCollider2D>();
        spawnArea.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lastSpawnTimeS < 0)
        {
            lastSpawnTimeS = Time.time;
            GameObject spawned = Instantiate(spawnedPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            spawned.transform.parent = transform;
            float x = spawnArea.offset.x;
            float y = spawnArea.offset.y;
            float w = spawnArea.size.x / 2;
            float h = spawnArea.size.y / 2;
            Vector3 pos = new Vector3(
                Random.Range(x - w / 2, x + w / 2),
                Random.Range(y - h / 2, y + h / 2),
                0);
            spawned.transform.localPosition = pos;
        }
        else if (lastSpawnTimeS >= 0 && Time.time - lastSpawnTimeS > spawnDelayS)
        {
            lastSpawnTimeS = -1;
        }
    }
}