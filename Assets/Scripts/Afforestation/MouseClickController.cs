using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickController : MonoBehaviour
{
    public Soil[] soil;
   
    public int counter = 0;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(counter);
        if (counter < soil.Length)
        {
            if //(Input.GetMouseButtonUp(0))
               (Input.GetKeyUp("space"))
            {
               /* RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit) && hit.collider == GetComponent<Soil>())
                {*/
                    soil[counter].positionswechsel();
                    
                    Debug.Log("earthpos: " + soil[counter].transform.position);
                    counter++;
                //}
            
            }
            
        }
    }
}
