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
   public float jumpForce;
   Rigidbody2D rb;
   public bool isGrounded;
    public GameManager gm;
// Start is called before the first frame update
    void Start()
    {    
    soundEffects = GetComponent<AudioSource>();
    sr = GetComponent<SpriteRenderer>();
    rb = GetComponent<Rigidbody2D>();  
    }
    // Update is called once per frame
    void Update()
    {
   Vector3 newPosition = transform.position;
        //variables to mirror the player
        Vector3 newScale = transform.localScale;
        float currentScale = Mathf.Abs(transform.localScale.x); //take absolute value of the current x scale, this is always positive
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= speed;
            newScale.x = -currentScale;
            
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x += speed;
            newScale.x = currentScale;
           
        }
        if (Input.GetKey("w") && isGrounded)
        {
             rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
      
        
        transform.position = newPosition;
        transform.localScale = newScale;
   }    
       private void OnCollisionEnter2D(Collision2D collision)     
    {
        if(collision.gameObject.tag.Equals("ground"))
        {
            Debug.Log("i got in");
            
            isGrounded = true;
        } 
        if(collision.gameObject.tag.Equals("coin"))
        {
            gm.score++;
            Destroy(collision.gameObject);
        } 
   
     
        
        if (collision.gameObject.tag.Equals("door1"))
        {
            Debug.Log("change scene");
            SceneManager.LoadScene(2);
        }
        
        
         if (collision.gameObject.tag.Equals("door2"))
        {
            Debug.Log("change scene");
            SceneManager.LoadScene(3);
        }
        if (collision.gameObject.tag.Equals("door3"))
        {
            Debug.Log("change scene");
            SceneManager.LoadScene(0);
        }
        
         //check if colliding with a game object with specific tag
        if (collision.gameObject.tag.Equals("box"))
        {
            Debug.Log("am dead");
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
        
     }
        
      private void OnCollisionExit2D(Collision2D collision)     
    {
        if(collision.gameObject.tag.Equals("ground"))
        {
              isGrounded = false;
        } 
    }

}