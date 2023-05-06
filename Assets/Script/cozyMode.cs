using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cozyMode : MonoBehaviour
{
    public Animator animasi;

    public void cozyOff()
    {
        animasi.SetBool("close", true);
    }
}
