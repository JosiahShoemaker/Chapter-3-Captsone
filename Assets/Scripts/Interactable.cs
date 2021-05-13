using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool grabbed;

    public virtual void Interacted()
    {
        Debug.Log("I am Interactable");
    }
        



}
