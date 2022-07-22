using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DA.DefrnseBasic
{
    public class Enemy : MonoBehaviour , IComponentChecking
    {
        public float speed;
        public float atkDistance;//khoang cach enemy tan cong
        public int minCoinBouns;
        public int maxCoinBouns;


        private Animator m_amin;
        private Rigidbody2D m_rb;
        private Player m_player;
        private bool m_isDead;

        private GameManager m_gm;

        private void Awake()
        {
            m_amin = GetComponent<Animator>();
            m_rb = GetComponent<Rigidbody2D>();
            m_player = FindObjectOfType<Player>();
            m_gm = FindObjectOfType<GameManager>();

        }
        // Start is called before the first frame update
        void Start()
        {

        }

        public bool IsComponentsNull()
        {
            return m_amin == null || m_rb == null || m_player == null || m_gm == null ;
        }
        // Update is called once per frame
        void Update()
        {
            if (IsComponentsNull()) return;//kiem tra = null ngat het cau lenh

            float distToPlayer = Vector2.Distance(m_player.transform.position, 
                transform.position);

          /*  if (m_rb)
                m_rb.velocity = new Vector2(-speed, m_rb.velocity.y);*/

            if (distToPlayer <= atkDistance)
            {
               // if (m_amin)
                m_amin.SetBool(Const.ATTACK_ANIM, true);
                m_rb.velocity = Vector2.zero;//vecto toa do (0,0)
            }
            else
            {
                m_rb.velocity = new Vector2(-speed, m_rb.velocity.y);
            }
        }

        public void Die()
        {
            if (IsComponentsNull() || m_isDead) return;

            m_isDead = true;
            m_amin.SetTrigger(Const.DEAD_ANIM);
            m_rb.velocity = Vector2.zero;

            gameObject.layer = LayerMask.NameToLayer(Const.DEAD_ANIM);
            Debug.Log("Die");
           // if (m_gm)
                m_gm.Score++;
            int coinBonus = Random.Range(minCoinBouns, maxCoinBouns);
            Debug.Log(coinBonus);
            Pref.coins = coinBonus;

            Destroy(gameObject, 2f);
        }
    }
}