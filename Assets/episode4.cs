using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class episode4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float dst = GetDistaceBetweenTwoPoints(0,0,0,0); // you put four numbers in example (x1,x2,y1,y2) it represens two points
        print(dst);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float GetDistaceBetweenTwoPoints(float x1, float y1, float x2, float y2)
    {
        float dx = x1 - x2;
        float dy = y1 - y2;
        float dstSquared = dx * dx + dy * dy;
        float dst = Mathf.Sqrt(dstSquared);
        return dst;
    }
}
