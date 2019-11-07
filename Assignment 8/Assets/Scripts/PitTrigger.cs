using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitTrigger : MonoBehaviour
{
    private Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FlareTrigger")
        {
            //playerRB.AddForce(Vector3.up, ForceMode.Acceleration);
            Debug.Log("Force Applied By FlareTrigger");
        }

        else if (other.gameObject.name == "SmokeTrigger")
        {
            //playerRB.AddForce(Vector3.up, ForceMode.Force);
            Debug.Log("Force Applied By SmokeTrigger");
        }

        else if (other.gameObject.name == "FireTrigger")
        {
            Debug.Log("Force Applied By FireTrigger");
            playerRB.AddForce(Vector3.up * 100 * Time.deltaTime, ForceMode.Impulse);
        }
            
        else if (other.gameObject.name == "SteamTrigger")
        {
            playerRB.AddForce(Vector3.up * 100 * Time.deltaTime, ForceMode.VelocityChange);
            Debug.Log("Force Applied By SteamTrigger");
        }
            
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "FlareTrigger")
            playerRB.AddForce(Vector3.up * 100 * Time.deltaTime, ForceMode.Acceleration);
        else if (other.gameObject.name == "SmokeTrigger")
            playerRB.AddForce(Vector3.up * 100 * Time.deltaTime, ForceMode.Force);
        else if (other.gameObject.name == "FireTrigger") { }
        //playerRB.AddForce(Vector3.up, ForceMode.Impulse);
        else if (other.gameObject.name == "SteamTrigger") { }
            //playerRB.AddForce(Vector3.up, ForceMode.VelocityChange);
    }
}
