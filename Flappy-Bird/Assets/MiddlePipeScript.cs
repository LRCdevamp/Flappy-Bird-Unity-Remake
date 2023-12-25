using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MiddlePipeScript : MonoBehaviour
{
    
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        /* I've made a new tag named " Logic " in Unity and set it for Logic Manager object. Using the above line, We put
         the LogicScript in logic, Thus we will be able to use it in future ( Line 31 ) */
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 3)
        {
            logic.addScore();
        }
    }
}
