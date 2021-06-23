using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    public GameObject[] Tree;

    private bool growing = false;
    
    private float passedTime = 0f;

    private Vector3 beginningScale = new Vector3(0.1f, 0.1f, 0.1f);

    private int counter = 0;

    void Start()
    {
        EventSystemBase.aCollisionEvent += this.processCollisionEvent;
    }

    void Update()
    {
        if (this.growing)
        {
            this.grow();
        }
        Debug.Log("eventlistener");
      
    }

    void processCollisionEvent(string type)
    {
        if (type == "grow")
        {
            this.growing = !this.growing;
            this.passedTime = 0.0f;
        }

    }

    private void grow()
    {
        this.passedTime += Time.deltaTime;
        if (counter < Tree.Length)
        {
           // this.passedTime += Time.deltaTime;

            if (passedTime < 10.0f)
            {
                Tree[counter].transform.localScale = Vector3.Lerp(new Vector3(0.2f, 0.2f, 0.2f), new Vector3(0.1f, 0.1f, 0.1f), 1 / this.passedTime);
                //Debug.Log(passedTime);
                counter++;
            }
        }
    }

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

