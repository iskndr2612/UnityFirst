using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRnd : MonoBehaviour
{
    public GameObject[] objects;
    private GameObject inst_objects;
    [SerializeField]
    private float RangeForObjects = 30f;

    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        inst_objects = Instantiate(objects[rand], objects[rand].transform.position, Quaternion.identity) as GameObject;
        inst_objects.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);

       // Invoke("Inst", 2f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
            StartCoroutine(instObj());
    }

    void Inst()
    {
        Instantiate(inst_objects, new Vector3(Random.Range(-1 * RangeForObjects, RangeForObjects), 0f, Random.Range(-1 * RangeForObjects, RangeForObjects)), Quaternion.identity);
    }

    IEnumerator instObj()
    {
        int rand2 = Random.Range(0, objects.Length);
        _ = Instantiate(objects[rand2], new Vector3(Random.Range(-1 * RangeForObjects, RangeForObjects), 0f, Random.Range(-1 * RangeForObjects, RangeForObjects)), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
       
    }

}
