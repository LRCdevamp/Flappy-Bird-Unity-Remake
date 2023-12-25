using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3 ;
    private float timer = 0;
    public float heightOffset = 5 ;
    
    // Start is called before the first frame update
    void Start()
    {
        // By calling spawnPipe method, We spawn one pipe at the beginning of the game so we wouldn't have to wait for
        // spawnRate seconds to see the first pipe. Our game would feel boring like that.
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        /* lowestPoint and highestPoint are method variables and the scope is actually inside the function. Thus we
        don't have to specify the visibility. */ 
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        // When we want to give new numbers for a vector, We always have to use new keyword.
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation);
        Debug.Log("Pipe Spawned");
    }

}

