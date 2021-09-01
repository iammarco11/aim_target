using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Transform camholder;
    float verticalcam;
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X"));
        verticalcam -= Input.GetAxisRaw("Mouse Y");
        verticalcam = Mathf.Clamp(verticalcam, -90f, 90f);
        camholder.localEulerAngles = new Vector3(verticalcam, 0, 0);
    }
}
