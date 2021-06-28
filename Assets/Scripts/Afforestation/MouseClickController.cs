using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickController : MonoBehaviour
{
    public GameObject[] mouseProxy;
    private Vector3[] earthPosition = {new Vector3(9.77911f, 0.00999999f, -5.668406f),
                                       new Vector3(10.2f, 0.00999999f, -4.5f),
                                       new Vector3(9.35f, 0.00999999f, -6.85f)};
    public int counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (counter < mouseProxy.Length)
        {
            if //(Input.GetMouseButtonUp(0) &&
               (Input.GetKeyUp("space"))
            {
               /* RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {*/
                    this.mouseProxy[counter].transform.position = earthPosition[counter]; ;//hit.transform.position;
                    //Debug.Log(hit.transform.position);
                    Debug.Log("earthpos: " + earthPosition[counter]);
                    counter++;
               /* }
                else
                {
                    this.mouseProxy[counter].transform.position = new Vector3(6.432689f, -1.215f, 5.361656f);
                }*/
            }
            Debug.Log("mouseclick");
        }
    }
}
