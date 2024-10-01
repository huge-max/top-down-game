using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
   public float speed;
   private SpriteRenderer sr;
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
          
       }

       if(Input.GetKey("a"))
       {
           newPosition.x -= speed;
           
       }

       if(Input.GetKey("w"))
       {
           newPosition.y += speed;
           
       }

       if(Input.GetKey("s"))
       {
           newPosition.y -= speed;
           
       }
        transform.position = newPosition;
    } 

    private void OnCollisionEnter2D(Collision2D collision)     
    {
        if (collision.gameObject.tag.Equals("door1"))
        {
            Debug.Log("i got in");
            SceneManager.LoadScene(1);
        }    
    }

}   
