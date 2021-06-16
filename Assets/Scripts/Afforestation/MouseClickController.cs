using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickController : MonoBehaviour
{
    public GameObject mouseProxy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                this.mouseProxy.transform.position = hit.transform.position;
            }
            else
            {   //können wir weglassen, da wir nicht wollen, dass Baum wieder zu Anfangsposition zurückkehrt
                this.mouseProxy.transform.position = new Vector3(-3f, 0.2f, 7f);
            }
        }
        Debug.Log("mouseclick");
    }
}
