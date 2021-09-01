using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public void Hit()
    {
        transform.position = TargetBoundary.Instance.getRandomPos();
    }
}
