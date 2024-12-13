using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPartrol : MonoBehaviour
{
  public GameObject pointA;
  public GameObject pointB;
  private Rigidbody2D rb;
  //private Transform currentPoint;
  public float speed = 1;
  // Start is called before the first frane update
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    //currentPoint = pointA.transform;
    rb.velocity = new Vector2(speed, 0);
  } 
    
    
    // Update is called once per frame
  void Update()
  {
     //Vector3 point = currentPoint.position - transform.position;
     Debug.Log("B: " + pointB.transform.position.x);
     Debug.Log("A: " + pointA.transform.position.x);

     if(transform.position.x > 7f)
     {
        rb.velocity = new Vector2(-speed, 0);
     }   
     if(transform.position.x <  -4f);
     {
        rb.velocity = new Vector2(speed, 0);
     }
     /*if(Vector2. Distance(transform.position, currentPoint.poSsition) < 0.5f && currentPoint == pointB. transform)
     {
       flip(); 
       currentPoint = pointA.transform;
     }   
       if (Vector2. Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA. transform)
     { flip();
       currentPoint = pointB. transform;
     }*/
  }   

  /*private void flip()
  {
        Vector3 localScale = transform.localScale;
        localScale.x *=-1;
        transform.localScale = localScale;
  }*/

  
}