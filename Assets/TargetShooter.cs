using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShooter : MonoBehaviour
{   
    [SerializeField] Camera cam;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Target target = hit.collider.gameObject.GetComponent<Target>();
                if (target)
                {
                    target.Hit();
                }
            }
        }
    }
}
