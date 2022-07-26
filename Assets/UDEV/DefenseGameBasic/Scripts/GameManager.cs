using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DA.DefrnseBasic
{
    public class GameManager : MonoBehaviour,IComponentChecking
    {
        public float spawnTime;
        public Enemy[] enemyPrefabs;
        public GUIManager guiMng;
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

        public void PlayGame()
        {
            StartCoroutine(SpawnEnemy());

            guiMng.ShowGameGUI(true);
            guiMng.UpdateGameplayCoins();
        }

        public bool IsComponentsNull()
        {
            return guiMng == null;
        }

        // Update is called once per frame
       
        public void Gameover()
        {
            if (m_isGameover) return;
            m_isGameover = true;
            Pref.bestScore = m_score;

            if(guiMng.gameoverDialog)
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
