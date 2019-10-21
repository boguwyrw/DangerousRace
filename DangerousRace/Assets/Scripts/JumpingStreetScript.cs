using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingStreetScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("PlayerTwo"))
        {
            transform.Translate(0.0f, 20 * Time.deltaTime, 0.0f);
        }
    }

}
