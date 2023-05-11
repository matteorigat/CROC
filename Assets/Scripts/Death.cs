using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour, IHittable
{
    public void Hit()
    {
        Debug.Log("DEAD");
    }
}
