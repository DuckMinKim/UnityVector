using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10.0f;
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(0f, speed / 3, 0f);
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.rotation = Quaternion.identity;
        }


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 vec = new Vector3(h, 0, v);
        transform.Translate(vec * speed * Time.deltaTime);

        float sx = transform.position.x;
        float sz = transform.position.z;

        if (sx < -9 || sx > 9 || sz < -9 || sz > 9)
        {
            Destroy(gameObject);
        }

    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("이얏!");
    }

    void OnDestroy()
    {
        Debug.Log("게임 오버~~");
    }

}
