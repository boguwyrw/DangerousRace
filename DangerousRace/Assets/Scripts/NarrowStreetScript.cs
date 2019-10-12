using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrowStreetScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.localScale = new Vector3(0.5f, 1.0f, 1.5f);
        }
    }

}
