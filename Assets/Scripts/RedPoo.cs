using UnityEngine;
using System.Collections;

public class RedPoo : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            PlayerClass _playerClass = other.GetComponent<PlayerClass>();
            _playerClass.WalkSpeed = 2f;
            Destroy(gameObject);
        }
        else {
            print("Buttplug used by other than player");
        }
    }
}
