using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{

    float rayLength = 10;

    LineRenderer line;

    [SerializeField]
    LayerMask layerMask;

    bool grabbing;

    Transform selected;
      

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                line.startColor = Color.green;
                selected = hit.transform;
                selected.SetParent(transform);
               // hit.transform.GetComponent<Interactable>().Interacted();
                //hit.transform.GetComponent<Interactable>().grabbed = true;
                grabbing = true;

                if (selected.localPosition.z < 1)
                    selected.localPosition = new Vector3(0, 0, 1);
                else
                    selected.localPosition = new Vector3(0, 0, selected.localPosition.z);
            }
            else
            {
                line.startColor = Color.red;
            }
        }

        if (OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger) || OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            line.startColor = Color.white;

            if (selected)
            {
                selected.SetParent(null);
                //selected.GetComponent<Interactable>().grabbed = false;
                selected = null;
                grabbing = false;

            }
        }

        if (grabbing)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                selected.Translate(transform.forward, selected.parent);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (selected.localPosition.z > 1)
                {
                    selected.Translate(-transform.forward, selected.parent);
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                selected.localPosition = new Vector3(0, 0, 2);
            }
        }

        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position + (transform.forward * rayLength));
    }

} 
