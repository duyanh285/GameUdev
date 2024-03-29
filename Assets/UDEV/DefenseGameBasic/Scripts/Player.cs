﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.DefrnseBasic
{
    public class Player : MonoBehaviour, IComponentChecking
    {
        public float atkRate;
        private Animator m_anim;
        private float m_curAtkRate;
        private bool m_isAttacked;
        private bool m_isDead;
        //private GameManager m_gm;

        private void Awake()
        {
            m_anim = GetComponent<Animator>();
            m_curAtkRate = atkRate;
           // m_gm = FindObjectOfType<GameManager>();
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        public bool IsComponentsNull()
        {
            return m_anim == null || GameManager.Ins == null; ;


        }
        // Update is called once per frame
        void Update()
        {
            if (IsComponentsNull()) return;

            if (Input.GetMouseButtonDown(0) && !m_isAttacked)//trang thai tan cong
            {
                // Debug.Log("Nguoi choi da bam chuot trai");
               // if (m_anim)
                m_anim.SetBool(Const.ATTACK_ANIM, true);
                m_isAttacked = true;
            }

            if (m_isAttacked)
            {
                m_curAtkRate -= Time.deltaTime;
                if (m_curAtkRate <= 0)
                {
                    m_isAttacked = false;
                    m_curAtkRate = atkRate;
                }
            }
        }

        public void ResetAtkAnim()//ve trang thai binh thuong
        {
            if (IsComponentsNull()) return;
                m_anim.SetBool(Const.ATTACK_ANIM, false);
        }

        public void PlayAtkSound()
        {
            // if (GameManager.Ins.auCtr)
            AudioController.Ins.PlaySound(AudioController.Ins.playerAtk);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (IsComponentsNull()) return;
             
            if (collision.CompareTag(Const.ENEMY_WEAPON_TAG) && !m_isDead)
            {
                m_anim.SetTrigger(Const.DEAD_ANIM);
                m_isDead = true;
                gameObject.layer = LayerMask.NameToLayer(Const.DEAD_LAYER);
                Debug.Log("player die");
                GameManager.Ins.Gameover();

            }
        }
    }
}