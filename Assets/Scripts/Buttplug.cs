using UnityEngine;
using System.Collections;

public class Buttplug : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other) {
        if (other.name == "Player") {
            PlayerClass _playerClass = other.GetComponent<PlayerClass>();
            _playerClass.LifeTime += 20f;
            Destroy(gameObject);
        }
        else {
            print("Buttplug used by other than player");
        }
    }
}