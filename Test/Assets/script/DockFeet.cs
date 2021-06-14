using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DockFeet : MonoBehaviour
{
    public Dock dock;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
        if (dock.groundCollision == 5)
        {
            print("dock:");
        }
        ++dock.groundCollision;
    }

    // Update is called once per frame
    void OnCollisionExit2D(Collision2D other)
    {
        --dock.groundCollision;
    }
}
