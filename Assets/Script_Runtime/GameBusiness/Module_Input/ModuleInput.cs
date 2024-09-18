using System;
using UnityEngine;


public class ModuleInput {
    public Vector3 moveAxis;


    public ModuleInput() {
        moveAxis = Vector3.zero;
    }

    public void ProcessMove() {
        Vector3 moveAxis = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) {
            moveAxis += Vector3.forward;
        } else if (Input.GetKey(KeyCode.S)) {
            moveAxis += Vector3.back;
        }

        if (Input.GetKey(KeyCode.A)) {
            moveAxis += Vector3.left;
        } else if (Input.GetKey(KeyCode.D)) {
            moveAxis += Vector3.right;
        }
        moveAxis.Normalize();
        this.moveAxis = moveAxis;

    }
}