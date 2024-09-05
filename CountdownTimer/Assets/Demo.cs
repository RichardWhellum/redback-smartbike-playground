using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Demo : MonoBehaviour
{
    [SerializeField] Timer timer1;

    private void Start()
    {
        timer1.SetDuration(100).Begin(); // Sets the timer for a duration in seconds and starts it
    }
}
