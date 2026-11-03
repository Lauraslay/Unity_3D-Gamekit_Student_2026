using UnityEngine;

public class WOrkshoopbs : MonoBehaviour
{
    private Transform thisTransform;
    private int num1 = 12;
    private int num2 = 24;
    
    int randomNumber = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisTransform = GetComponent<Transform>();
        num1 = num2;
        
        randomNumber = Random.Range(0, 11);
        
        if (RandomizedNumber() < 5)
        {
            Debug.Log(RandomizedNumber());
        }
        else
        {
            Debug.Log("too big :(");
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            thisTransform.Translate(0, 1, 0);
        }

        
    }*/

    int RandomizedNumber()
    {
        int randomizeMe;
        randomizeMe = randomNumber;
        randomizeMe++;
        return randomizeMe;
    }
}
