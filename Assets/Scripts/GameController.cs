using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    float rayLenght = 10;

    LineRenderer line;
    [SerializeField]
    LayerMask layerMask;
      

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayLenght, layerMask))
            {
                line.startColor = Color.green;
            }
            else
            {
                line.startColor = Color.red;
            }
        }
    }   
} 
