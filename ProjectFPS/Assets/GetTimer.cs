using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTimer : MonoBehaviour
{
    public float timer;
    private void Start()
    {
        timer = Time.time;
    }
}
