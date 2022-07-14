using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    float score;
    float time;
    public Transform myTransform;
    public SpriteRenderer sp;
    //public Demo demoScript;

    //public GameObject heroPrefab;
  //  public Transform myTransform;

    private void Awake()
    {
        // Debug.Log("Awake");
        sp = GetComponent<SpriteRenderer>();       
    }

    private void OnEnable()
    {
       // Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Start");
        // myTransform.localScale
        /*   if (heroPrefab)
           {
               var heroClone = Instantiate(heroPrefab, new Vector3(3.5f, 1.5f, 0f), Quaternion.identity);

               Destroy(heroClone, 4f);
           }*/

        /*  if (sp)
              sp.color = Color.red;*/


        //StartCoroutine(DemoCo());

        // Invoke("Work", 3);

        /* score += 10;

         PlayerPrefs.SetFloat("score", score);

         float scoreCopy = PlayerPrefs.GetFloat("score", 0);
         Debug.Log(scoreCopy);
 */

        /*score = PlayerPrefs.GetFloat("score", 0);
        score += 1;
        PlayerPrefs.SetFloat("score", score);
        Debug.Log(score);*/

        time = PlayerPrefs.GetFloat("time", 0);
        time += 1;
        PlayerPrefs.SetFloat("time", time);
        Debug.Log(time);
    }



   /* private IEnumerator DemoCo()
    {
        yield return new WaitForSeconds(3);
        // Debug.Log("dang xu li cong viec 1");
        Debug.Log(GetComponent<SpriteRenderer>().color = Color.green);
        yield return new WaitForSeconds(2);
       // Debug.Log("dang xu li cong viec 2");
        Debug.Log(GetComponent<SpriteRenderer>().color = Color.yellow);
        yield return new WaitForSeconds(3);
       // Debug.Log("dang xu li cong viec 2");
        Debug.Log(GetComponent<SpriteRenderer>().color = Color.red);
    }*/

    /*private void Work()
    {
        Debug.Log("Conmg viec can thuc hien");
        Debug.Log(GetComponent<SpriteRenderer>().color = Color.green);
        Debug.Log(GetComponent<SpriteRenderer>().color = Color.yellow);
    }*/

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Update");
        //Debug.Log(Time.deltaTime);

      /*  var vectordemo = new Vector2(1.3f, 5);
        myTransform.position = new Vector3(2, 1, 8);

        myTransform.localScale = new Vector3(5, 5, 5);
*/
    }

    private void OnDisable()
    {
       // Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
       // Debug.Log("OnDestroy");
    }

    /*private void OnCollisionEnter2D(Collision2D collision)//chay 1 lan
    {
        // Debug.Log(collision.gameObject.GetComponent<SpriteRenderer>().color = Color.green);
        Debug.Log("Da va cham voi nhau");
    }

    private void OnCollisionStay2D(Collision2D collision)//chay lien tuc
    {
        Debug.Log("2 doi tuong va cham");
    }

    private void OnCollisionExit2D(Collision2D collision)//chay dang va cham 1 li do gi do dung lai
    {
        Debug.Log("2 doi tuong ko con va cham nhau");
    }*/

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Da va cham voi nhau");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("2 doi tuong game dang va cham voi nhau");
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("2 doi tuong game ko va cham voi nhau");
    }
    */
}
