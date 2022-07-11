using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public Transform myTransform;
    public SpriteRenderer sp;
    public Demo demoScript;

    public GameObject heroPrefab;
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
        if (heroPrefab)
        {
            var heroClone = Instantiate(heroPrefab, new Vector3(3.5f, 1.5f, 0f), Quaternion.identity);

            Destroy(heroClone,4f);
        }

        if (sp)
            sp.color = Color.red;
    }

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
}
