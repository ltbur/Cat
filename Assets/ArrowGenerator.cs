using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject prefab;
    float span=1.0f;
    float delta=0;

    IEnumerator ArrowGenerate(){
        while(true){
            yield return new WaitForSeconds(1f);
            Instantiate(
                prefab,
                new Vector3(Random.Range(-6f,6f),7f,0),
                Quaternion.identity
                );
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.delta+=Time.deltaTime;
        if(this.delta > this.span){
            this.delta=0;
            GameObject obj=Instantiate(prefab);
            
        }
    }
}