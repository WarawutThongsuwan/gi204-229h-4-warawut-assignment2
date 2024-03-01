using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRB : MonoBehaviour
{
    public float speed = 5f; // ความเร็วของการเคลื่อนที่

    private Rigidbody rb; // Rigidbody ของ GameObject

    void Start()
    {
        // รับค่า Rigidbody จาก GameObject นี้
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        // รับค่าความเคลื่อนที่จากแกนแนวนอนและแนวตั้ง
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // สร้างเวกเตอร์เคลื่อนที่
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // ให้ Rigidbody ของ GameObject เคลื่อนที่ตามเวกเตอร์ movement ด้วยความเร็ว speed
        rb.AddForce(movement * -speed);
    }
}
