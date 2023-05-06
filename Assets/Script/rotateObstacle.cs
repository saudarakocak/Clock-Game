using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObstacle : MonoBehaviour
{
    public float rotateSpeed;
    public bool left, right;

    void Update()
    {
        if (left) 
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime) ; 
        }else if (right)
        {
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime * -1);
        }
    }
}
