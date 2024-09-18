using System;
using UnityEngine;



public class PlayerEntity : MonoBehaviour {


    public int id;

    public float moveSpeed;

    public void Ctor() {
        moveSpeed = 15;
    }

    public void Move(Vector3 moveAxis, float dt) {

        Vector3 pos = transform.position;

        pos += moveAxis * moveSpeed * dt;

        transform.position = pos;

    }
}