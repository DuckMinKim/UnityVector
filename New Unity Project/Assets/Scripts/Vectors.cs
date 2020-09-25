using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    void Start()
    {
        //Vector2 vector2 = new Vector2(1f, 2f);
        //Vector3 vector3 = new Vector3(1f, 2f, 3f);

        //Debug.Log("vector2 = " + vector2);
        //Debug.Log("vector3 = " + vector3);

        Vector3 v1 = new Vector3(1f, 2f, 0f);
        Vector3 v2 = new Vector3(2f, 1f, 0f);

        Debug.Log("v1 + v2 = " + (v1 + v2));
        Debug.Log("v1 - v2 = " + (v1 - v2));

        Vector3 v3 = new Vector3(3f, 4f, 0f);
        int scalar = 4;

        Debug.Log("v3 * scalar =" + (v3 * scalar));
        Debug.Log("|v3| =" + (v3.magnitude));

        Vector3 v4 = new Vector3(4f, 3f, 0f);
        Vector3 v5 = new Vector3(6f, 0f, 0f);

        Debug.Log("v4 · v5 =" + Vector3.Dot(v4, v5));
        Debug.Log("v4과 v5 각도 =" + Vector3.Angle(v4, v5));

        Vector3 v6 = new Vector3(1f, 0f, 0f);
        Vector3 v7 = new Vector3(0f, 2f, 0f);

        Debug.Log("v6 × v7 =" + Vector3.Cross(v6, v7));
        Debug.Log("v6과 v7 넓이 =" + Vector3.Cross(v6, v7).magnitude);

    }
}
