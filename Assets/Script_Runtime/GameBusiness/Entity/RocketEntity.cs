using System;
using UnityEngine;



public class RocketEntity : MonoBehaviour {
    public int id;
    public int typeID;
    public int moveSpeed;

    public void Ctor() {
        moveSpeed = 10;
    }

    public void SetPos(Vector3 pos) {
        transform.position = pos;
    }

    
}