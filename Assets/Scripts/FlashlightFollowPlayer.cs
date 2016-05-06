using UnityEngine;
using System.Collections;

public class FlashlightFollowPlayer : MonoBehaviour {

    public GameObject target;

    void Start() {

    }

    void Update() {
        Vector3 targetPos = target.transform.position;
        Quaternion targetRot = target.transform.rotation;
        targetPos.z = -0.155f;
        transform.position = targetPos;

        Vector3 _diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        _diff.Normalize();
        float _rotZ = Mathf.Atan2(_diff.x, _diff.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(_rotZ - 90, 90f, 0f);
       
        //transform.Rotate(new Vector3(0,transform.rotation.z - target.transform.rotation.z,0));
        //transform.rotation = targetRot;
    }
}