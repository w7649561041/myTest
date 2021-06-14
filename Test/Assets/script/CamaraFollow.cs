using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    Transform _transform;
    public float smoth = 5f;
    Vector3 offset;
    void Start()
    {
        _transform = GetComponent<Transform>();    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followPos = new Vector3(target.position.x + smoth, target.position.y,-10);
        _transform.position = followPos;
    }
}
