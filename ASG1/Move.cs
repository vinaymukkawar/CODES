using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            transform.Translate(0f, 0.1f, 0f);

        if (Input.GetKeyDown(KeyCode.S))
            transform.Translate(0f, -0.1f, 0f);

        if (Input.GetKeyDown(KeyCode.X))
            transform.Rotate(0f, 0.5f, 0f);

        if (Input.GetKeyDown(KeyCode.C))
            transform.localScale = new Vector3(5f, 5f, 5f);

        if (Input.GetKeyDown(KeyCode.V))
            transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
