using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerClick : MonoBehaviour
{
    private bool isClicked;
    [SerializeField] Rigidbody Sphere;

    // Update is called once per frame
    void Update()
    {
        if (this.isClicked)
        {
            return;
        }

        if (Input.GetMouseButton(0))
        {
            Sphere.useGravity = true;
            this.isClicked = true;
        }
    }
}
