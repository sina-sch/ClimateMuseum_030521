using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        EventSystemBase.aCollisionEvent("grow");
        Debug.Log("growcollision");
    }
}
