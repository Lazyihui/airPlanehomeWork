using System;
using UnityEngine;


public class BackgroundEntity : MonoBehaviour {

    public int id;

    public float moveSpeed;

    public void Ctor() {
        moveSpeed = 10;
    }

    public void SetPos(Vector3 pos) {
        transform.position = pos;
    }

    public void Move(float dt) {

        Vector3 pos = transform.position;

        pos += moveSpeed * Vector3.forward * dt;

        transform.position = pos;

        if (pos.z > 136) {
            transform.position = new Vector3(pos.x, pos.y, -159);
        }

    }

}