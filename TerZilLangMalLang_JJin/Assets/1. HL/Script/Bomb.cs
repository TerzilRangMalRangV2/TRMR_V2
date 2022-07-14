using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float speed = 5f;
    public int getDamage_NB = 10;

    GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        

        this.transform.position += -player.transform.right * speed * Time.deltaTime;


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        //수빈이 적 스크립트
        //일반공격은 적의 HP를 적게 깜
        //BossPatern
        BossPatern enemy = collision.GetComponent<BossPatern>();
        if (enemy != null)
        {
            BossHP.instance.HP -= getDamage_NB; // 보스의 HP 많이 까임

        }
    }

}
