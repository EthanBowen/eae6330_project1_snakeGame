using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float xLimit = 13.7f;
    public float yLimit = 7.5f;

    public 

    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        transform.position = new Vector3(Random.Range(-xLimit, xLimit), Random.Range(-yLimit, yLimit));
    }
}
