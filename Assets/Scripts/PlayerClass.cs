using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//using UnityEditor;

public class PlayerClass : MonoBehaviour {
    public float WalkSpeed = 2.0f;
    public float LifeTime = 100f;
    public bool PaperFound = false;
    public int PoopChance = 50;
    public GUIText OutputText;
    GameObject[] _poo;
    

    void Start() {
        _poo = GameObject.FindGameObjectsWithTag("Poo");
    }

    void Update() {
        LifeTime -= Time.deltaTime;
        
        if (LifeTime <= 0) {
            Die();
        }

        if (Mathf.Floor(Random.Range(0, PoopChance)) == 1) {
            Poop();
        }

        //UpdateTime(LifeTime);
        LookAtMouse();

        if (Input.GetKey(KeyCode.Space)) {
            Poop();
        }

        Vector3 _dir = new Vector3();
        if (Input.GetKey(KeyCode.W)) {
            _dir.y += 1f;
        }
        else if (Input.GetKey(KeyCode.A)) {
            _dir.x -= 1f;
        }
        else if (Input.GetKey(KeyCode.S)) {
            _dir.y -= 1f;
        }
        else if (Input.GetKey(KeyCode.D)) {
            _dir.x += 1f;
        }
        else {
        }

        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
        _dir.Normalize();
        transform.Translate(_dir*Time.deltaTime*WalkSpeed);
    }

    void LookAtMouse() {
        Vector3 _diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        _diff.Normalize();
        float _rotZ = Mathf.Atan2(_diff.y, _diff.x)*Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, _rotZ - 90);
    }

    void UpdateTime(float timeLeft) {
        GUIText _count = transform.Find("Canvas").GetChild(1).GetComponent<GUIText>();
        _count.text = timeLeft.ToString();
    }

    void Die() {
       // OutputText.text();
        
        
    }

	public void WinLevel (){
		print("Game WON! WHOOHOO");
	}

    void Poop() {
        
        int _randomInt = Random.Range(0, _poo.Length);
        Instantiate(_poo[_randomInt], transform.position, transform.rotation);
    }
}