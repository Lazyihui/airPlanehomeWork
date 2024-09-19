using System;
using UnityEngine;



public class RocketEntity : MonoBehaviour {
    public int id;
    public int typeID;
    public int moveSpeed;

    public void Ctor() {
        moveSpeed = 20;
    }

    public void SetPos(Vector3 pos) {
        transform.position = pos;
    }

    public void Move(float dt) {
        Vector3 pos = transform.position;
        pos.z += moveSpeed * dt ;
        transform.position = pos;
    }


}