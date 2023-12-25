using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogScript : MonoBehaviour
{
    public Rigidbody2D frogRigidbody;
    public float jumpStrengh;
    public LogicScript logic;
    public bool isFrogAlive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isFrogAlive)
        {
            frogRigidbody.velocity = Vector2.up * jumpStrengh;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        isFrogAlive = false;
        logic.gameOver();
    }
}