using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutin
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetRandomPosition()
	{
		float x = Random.Range(-5.0f, 5.0f);
		float z = Random.Range(-5.0f, 5.0f);
		transform.position = new Vector3(x, 0.0f, z);
	}
}
