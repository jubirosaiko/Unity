﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    public float speed = 10;

    void FixedUpdate() {
        //入力をxとyに代入
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //同一のgameobjectが持つRigidbodyコンポーネントを取得
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        //rigidbodyのx軸(横)とz軸(奥)に力を加える
        rigidbody.AddForce(x*speed, 0, z*speed);

    }
}