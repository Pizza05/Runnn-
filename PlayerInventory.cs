using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public float speed;
    public TMPro.TextMeshPro labalCoin;

    private int coin;

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Coin") // tag coin เพื่อ Object อื่่นที่ไม่ใช่ coin มาทำลายตัวเอง
        {
            Destroy(other.gameObject);

            coin++;

            labalCoin.text = coin.ToString();
        }
    }
}
