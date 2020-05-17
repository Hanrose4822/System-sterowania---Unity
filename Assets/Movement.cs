using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody ballPrefab;
    public Transform cam;
    public Rigidbody human;
    public Transform position;
    private float rot;
    public float force;
    public float destroyDelay;
    public Transform launchPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.x -= (float)0.1;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.x += (float)0.1;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.z -= (float) 0.1;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.z += (float) 0.1;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.y += (float) 0.1;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.y -= (float) 0.1;
            this.transform.position = position;
        }
        
    }

    
}
