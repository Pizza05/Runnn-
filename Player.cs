using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Camera Cam;
    public NavMeshAgent player;
    private object cm;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //การคุมตัวละครด้วยการคล๊กเมาส์ 
        { 
          Ray ray = Cam.ScreenPointToRay(Input.mousePosition); //คลิ๊กเมาส์ที่ ที่ต้องการให้ตัวละครเตล่ื่อนี่ไปตามเมาส์
          RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) 
            {
              player.SetDestination(hit.point);
            }
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        //เม่ื่อผู้เล่นเข้าใกล้ Coin Coin จะทำลายตัวเอง
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            
        }
    }
}
