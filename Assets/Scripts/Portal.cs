using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform destination;

    public bool isOrange;
    public float distance = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
      if(isOrange == false)
      {
          destination = GameObject.FindGameObjectWithTag("OrangePortal").GetComponent<Transform>();
      }
      else
      {
          destination = GameObject.FindGameObjectWithTag("BluePortal").GetComponent<Transform>();
      }   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      if(Vector2.Distance(transform.position, other.transform.position) > distance)
      {
          other.transform.position = new Vector2(destination.position.x, destination.position.y); 
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
