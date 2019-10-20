using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RePositionWithDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator RePositionWithDelay()
    {   // this will run forever
        while(true)
        {
            SetRandomPosition();
            yield return new WaitForSeconds(5);
        }
    }

    void SetRandomPosition()
	{
		float x = Random.Range(-5.0f, 5.0f);
		float z = Random.Range(-5.0f, 5.0f);
		transform.position = new Vector3(x, 0.0f, z);
	}
}
