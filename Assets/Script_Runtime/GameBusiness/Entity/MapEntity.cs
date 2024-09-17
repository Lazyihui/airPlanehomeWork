using System;
using UnityEngine;



public class MapEntity : MonoBehaviour {

    [SerializeField] MapEleEntity mapEleEntity;

    public int id;


    public void Ctor() {
    }

    public void SpawnEle() {
     
        MapEleEntity ele = Instantiate(mapEleEntity, transform.position, Quaternion.identity);
        ele.id++;
        ele.Ctor();
        
    }


}