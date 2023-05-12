using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptofsomekind : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.rotation = new Quaternion(0,speed * Time.deltaTime,0,0);
    }
}
