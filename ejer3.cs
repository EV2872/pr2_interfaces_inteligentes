using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer3 : MonoBehaviour
{
    public Vector3 vec1;
    public Vector3 vec2;
    // Start is called before the first frame update
    void Start()
    {
        vec1 = new Vector3(0.0f, 1.0f, 0.0f);
        vec2 = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(vec1.magnitude);
        Debug.Log(vec2.magnitude);
        Debug.Log("Angulo = " + Vector3.Angle(vec1, vec2));
        Debug.Log("Distancia = " + Vector3.Distance(vec1, vec2));
        if (vec1[2] > vec2[2]) {
            Debug.Log("Vec1 esta a mas altura");
        }  else if(vec1[2] == vec2[2]) {
            Debug.Log("Vec1 esta a la misma altura que Vec2");
        }
        else {
            Debug.Log("Vec2 esta a mas altura");
        }
    }
}
