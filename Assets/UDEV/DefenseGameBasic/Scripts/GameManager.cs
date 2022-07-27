using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DA.DefrnseBasic
{
    public class GameManager : MonoBehaviour, IComponentChecking
    {
        public float spawnTime;
        public Enemy[] enemyPrefabs;
        public GUIManager guiMng;
        public ShopManager shopMng;
        private Player m_curPlayer;
        private bool m_isGameover;
        private int m_score;


        public int Score { get => m_score; set => m_score = value; }


        // Start is called before the first frame update
        void Start()
        {
            if (IsComponentsNull()) return;

            guiMng.ShowGameGUI(false);
            guiMng.UpdateMainCoins();
        }

        public bool IsComponentsNull()
        {
            return guiMng == null || shopMng == null;
        }


        public void PlayGame()
        {
            ActivePlayer();
            StartCoroutine(SpawnEnemy());

            guiMng.ShowGameGUI(true);
            guiMng.UpdateGameplayCoins();


        }

        public void ActivePlayer()
        {
            if (IsComponentsNull()) return;

            if (m_curPlayer)
                Destroy(m_curPlayer.gameObject);

            var shopItems = shopMng.items;

            if (shopItems == null || shopItems.Length <= 0) return;

            var newPlayerPb = shopItems[Pref.curPlayerId].playerPrefab;

            if (newPlayerPb)
                m_curPlayer = Instantiate(newPlayerPb, new Vector3(-7f, -1f, 0f), Quaternion.identity);
        }
        // Update is called once per frame

        public void Gameover()
        {
            if (m_isGameover) return;
            m_isGameover = true;
            Pref.bestScore = m_score;

            if (guiMng.gameoverDialog)
                guiMng.gameoverDialog.Show(true);

        }
        IEnumerator SpawnEnemy()
        {
            while (!m_isGameover)
            {
                if (enemyPrefabs != null && enemyPrefabs.Length > 0)
                {
                    int randIdx = Random.Range(0, enemyPrefabs.Length);//chuyen khoang tu (0,3) 0,1,3

                    Enemy enemyPrefab = enemyPrefabs[randIdx];

                    if (enemyPrefab)
                    {
                        Instantiate(enemyPrefab, new Vector3(8, 0, 0), Quaternion.identity);
                    }
                }
                yield return new WaitForSeconds(spawnTime);
            }
        }
    }
}
