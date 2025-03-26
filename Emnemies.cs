using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Emnemies : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ทำให้Enemy จะไล่ตามผู้เล่น
        enemy.SetDestination(Player.position);
    }

    void OnTriggerEnter(Collider other)
    {
        //เมื่อEnemy เช้าใกล้ player player จะทำลายคัวเอง
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}
