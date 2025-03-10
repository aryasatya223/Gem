using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    public float speed = 2;
    int dir = 1;

    public Transform rightCheck;
    public Transform leftCheck;

    void FixedUpdate()
    {
        // Memanggil Translate melalui transform milik GameObject ini
        transform.Translate(Vector2.right * speed * dir * Time.fixedDeltaTime);

        // Menggunakan Physics2D (bukan physics2D) untuk Raycast
        if (Physics2D.Raycast(rightCheck.position, Vector2.down, 2) == false)
            dir = -1;

        if (Physics2D.Raycast(leftCheck.position, Vector2.down, 2) == false)
            dir = 1;
    }
}
