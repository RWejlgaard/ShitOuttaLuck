using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateTimer : MonoBehaviour {
    bool IsCounting = true;
    PlayerClass _playerClass;
    float _value;

    void Start() {
        _playerClass = GameObject.Find("Player").GetComponent<PlayerClass>();
    }
    
    void Update() {
        while (IsCounting) {
            _value = _playerClass.LifeTime;
            GetComponent<Text>().text = _value.ToString();
            if (_value <= 0f) {
                IsCounting = false;
            }
        }
    }
}