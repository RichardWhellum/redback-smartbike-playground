using System.Collections;
using UnityEngine;

public class Demo2 : MonoBehaviour
{
    [SerializeField] Timer timer1;

    private void Start()
    {
        timer1.Begin(); // Start the timer 
    }
}
