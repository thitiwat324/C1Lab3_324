using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myring : MonoBehaviour
{
    public GameObject prefab;
    public int numberOfObjects=5;
    public float radius;
    

    // Start is called before the first frame update
    void Start()
    {
        this.create_ring();
    }
    void create_ring()
    {
        for (int i = 0; i <numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            Vector3 pos = transform.position + new Vector3(x, 0, z);
            float angleDegrees = -angle*Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(prefab, pos, rot);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
