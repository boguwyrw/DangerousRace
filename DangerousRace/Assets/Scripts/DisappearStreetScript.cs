using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearStreetScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("PlayerTwo"))
        {
            Destroy(gameObject);
        }
    }

}
