using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shoot : MonoBehaviour
{
    public Rigidbody ballPrefab;
    public Rigidbody bombPrefab;
    public float force;
    public float destroyDelay;
    public Transform launchPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Strzal();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            RzutBomba();
        }
        
    }
    private void Strzal()
    {
        Rigidbody cannonBall = Instantiate(ballPrefab, launchPosition.transform.position, launchPosition.transform.rotation);
        cannonBall.AddForce(launchPosition.forward * force, ForceMode.Impulse);
        Destroy(cannonBall.gameObject, destroyDelay);
    }

    private void RzutBomba()
    {
        Rigidbody bomb = Instantiate(bombPrefab, launchPosition.transform.position, launchPosition.transform.rotation);
        bomb.AddForce(launchPosition.forward * force, ForceMode.Impulse);
        Destroy(bomb.gameObject, destroyDelay);
    }
    private void OnMouseDown()
    {
        Strzal();
    }
}
