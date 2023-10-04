using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer4 : MonoBehaviour
{
    Vector3 myVec;
    // Start is called before the first frame update
    void Start()
    {
        myVec = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Posicion esfera: " + myVec);
    }
}
