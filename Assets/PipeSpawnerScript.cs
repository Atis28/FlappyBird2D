using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
     private float highOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowPoint = transform.position.y - highOffset;
        float highPoint = transform.position.y + highOffset;

        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(lowPoint, highPoint), 0), transform.rotation);
    }
}
