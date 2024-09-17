using System;
using UnityEngine;


public class MapEleEntity : MonoBehaviour {

    public int id;

    public float moveSpeed;

    public void Ctor() {
        moveSpeed = 1;
    }

    public void Move(float dt) {

        Vector3 pos = transform.position;

        pos += moveSpeed * Vector3.up * dt;

        transform.position = pos;

        if (pos.z > 136) {
            transform.position = new Vector3(pos.x, pos.y, -136);
        }

    }

}