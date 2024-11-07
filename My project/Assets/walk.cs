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
   public bool hasKey = false;
   public AudioSource soundEffects;
   public AudioClip itemCollect;
   public AudioClip doorEnter;
   public AudioClip[] sound;
   public static playermovement instance;
// Start is called before the first frame update
    void Start()
    {    
    soundEffects = GetComponent<AudioSource>();
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
            soundEffects.PlayOneShot(sound[0], .7f);
            SceneManager.LoadScene(1);
        }    
        
        if (collision.gameObject.tag.Equals("key"))
        {
            Debug.Log("got the key");
            soundEffects.PlayOneShot(sound[2], .7f);
            hasKey = true;
        }  
        
         if (collision.gameObject.tag.Equals("door2") && hasKey == true)
        {
             Debug.Log("open");
             soundEffects.PlayOneShot(sound[1], .7f);
             SceneManager.LoadScene(2);

        }
    
        if (collision.gameObject.tag.Equals("door3"))
        {
             Debug.Log("open");
             //soundEffects.PlayOneShot(sound[1], .7f);
             SceneManager.LoadScene(3);

        }
          
          
    }

}   

