using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoRandomMove : MonoBehaviour
{
    public Rigidbody cube;
    void Start()
    {
        StartCoroutine(MoveObject());
        
    }
    IEnumerator MoveObject()
    {
        cube = GetComponent<Rigidbody>();
        while (true)
        {
            float dir1 = Random.Range(-1f, 1f);
            float dir2 = Random.Range(-1f, 1f);

            yield return new WaitForSeconds(2);
            cube.velocity = new Vector3(dir1, 3, dir2); 

        }
    }


}
