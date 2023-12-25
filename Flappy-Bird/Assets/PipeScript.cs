using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float pipeMoveSpeed;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeMoveSpeed * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            Debug.Log("Pipe Deleted");
        }
    }
}