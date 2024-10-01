using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
   public float speed;
   private SriteRenderer sr;
   public Sprite upSprite;
   public Sprite downSprite;
   public Sprite leftSprite;
   public Sprite rightSprite;
// Start is called before the first frame update
    void Start()
    {
       sr = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
   
       Vector3 newPosition = transform.position;

       if(Input.GetKey("d"))
       {
           newPosition.x += speed;
           sr.sprite = rightSprite;
       }

       if(Input.GetKey("a"))
       {
           newPosition.x -= speed;
           sr.sprite = leftSprite;
       }

       if(Input.GetKey("w"))
       {
           newPosition.y += speed;
           sr.sprite = upSprite;
       }

       if(Input.GetKey("s"))
       {
           newPosition.y -= speed;
           sr.sprite = downSprite;
       }
        transform.position = newPosition;
    } 

         
}
