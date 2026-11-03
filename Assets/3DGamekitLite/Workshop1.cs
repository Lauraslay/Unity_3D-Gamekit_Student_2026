using System.Timers;
using Cinemachine;
using UnityEngine;

public class Workshop1 : MonoBehaviour
{
    public int myNumber = 0;
    public int myNumber2 = 0;
    public int myNumber3 = 0;
    // Dom här ska alltid vara här
    bool lovesMetroid = true;
    string name = "lala";
    float speed = 13.37f;
    int age = 67;

    private Rigidbody2D rb;
    private Collider2D attackCollider;
    
    private float timeRemaining = 10f;
    
    // Döper SpriteRenderer till sr 
    //private Transform thisTransform;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myNumber3++;
        //myNumber = Random.Range(0, 10);
        // Finns i unity på spriten
        //thisTransform = GetComponent<Transform>();
        //thisTransform.position.y = 5f;
        //thisTransform.Translate(0, 5, 0);
        
        rb = GetComponent<Rigidbody2D>();
        attackCollider = GetComponent<Collider2D>();

        /*for (int counter = 0; counter < 360; counter++)
        {
            
        }*/
        
        
        
    }

    // Update is called once per frame
    void Update()
    { 
        //NewMethod();
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("key pressed down");
            myNumber = 1;
            YSpeed();
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("key pressed up");
            myNumber = 0;
            YSpeed();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            myNumber2 = 1;
            XSpeed();
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            myNumber2 = 0;
            XSpeed();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myNumber2 = -1;
            XSpeed();
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            myNumber2 = 0;
            XSpeed();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myNumber = -1;
            YSpeed();
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            myNumber = 0;
            YSpeed();
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            ZRotate();
            myNumber3 = 1;
            attackCollider.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            ZRotate();
            myNumber3 = 0;
            attackCollider.enabled = false;
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        if (timeRemaining <= 0)
        {
            Destroy(gameObject);
        }
    }

    void YSpeed()
    {
        if (myNumber == 1)
        {
            rb.linearVelocityY = 3f;
        }
        else
        {
            Debug.Log(myNumber);
        }

        if (myNumber == 0)
        {
            rb.linearVelocityY = 0f;
        }

        if (myNumber == -1)
        {
            rb.linearVelocityY = -3f;
        }
    }

    void XSpeed()
    {
        if (myNumber2 == 0)
        {
            rb.linearVelocityX = 0f;
        }
        else if (myNumber2 == 1)
        {
            rb.linearVelocityX = -3f;
        }
        
        if (myNumber2 == -1)
        {
            rb.linearVelocityX = 3f;
        }
        
    }
    
    void ZRotate()
    {
        if (myNumber3 == 1)
        {
            rb.rotation = rb.rotation + 3f;
        }
    }
    
}
