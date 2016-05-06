using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Paper : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other) {
        if (other.name == "Player") {
            PlayerClass _playerClass = other.GetComponent<PlayerClass>();
            _playerClass.PaperFound = true;
            Destroy(gameObject);
            print("Paper found! Get back before it's too late");
        }
        else {
            print("Trigger activated by foreign action");
        }
    }
}