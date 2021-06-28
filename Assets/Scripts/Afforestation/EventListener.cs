using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    //public GameObject[] Tree;

    private bool growing = false;
    
    private float passedTime = 0f;

    private Vector3 beginningScale = new Vector3(0.1f, 0.1f, 0.1f);

    private int counter = -1;

    void Start()
    {
        EventSystemBase.aCollisionEvent += this.processCollisionEvent;
    }

    void Update()
    {
        if (this.growing)
        {
            Tree.grow();
        }
        Debug.Log("eventlistener");
      
    }

    void processCollisionEvent(string type)
    {
        if (type == "grow")
        {
            this.growing = true;
            this.passedTime = 0.0f;
            // counter hier hochzählen lassen, nicht in grow()
            counter++;
            Debug.Log("counter: " + this.counter);
        }

    }

   /* private void grow()
    {
       /* this.passedTime += Time.deltaTime;
        if (this.counter < Tree.Length)
        {
            if (this.passedTime < 10.0f)
            {

                //for (int i = 0; i <= counter;  i++)
                //{

                Tree[counter].transform.localScale = Vector3.Lerp(new Vector3(0.2f, 0.2f, 0.2f),
                                                            beginningScale, // oder:
                                                                            // Tree[i].transform.localScale,
                                                            1 / this.passedTime);
                //Debug.Log("counter: " + this.counter);
                Debug.Log("scale " + this.counter + ": " + Tree[this.counter].transform.localScale);
                //counter++;

                //}


            }
        }
    }*/

    /*private void grow()
    {
        this.passedTime += Time.deltaTime;
        //Tree.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
        while (Tree.transform.localScale.x < 0.8)
        {
            Tree.transform.localScale = beginningScale * Time.deltaTime;
        }
    }*/
}

