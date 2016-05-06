using UnityEngine;
using System.Collections;

public class Toilet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
		PlayerClass _playerclass = other.GetComponent<PlayerClass> ();
		if (_playerclass.PaperFound == true && _playerclass.LifeTime >= 0f) {
			WinLevel();
		}
    }

	void WinLevel (){
		print("Game WON! WHOOHOO");
	}
}
