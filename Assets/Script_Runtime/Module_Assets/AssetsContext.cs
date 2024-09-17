using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AssetsContext {

    public Dictionary<string, GameObject> entiies;

    public AsyncOperationHandle entityPtr;


    public AssetsContext() {
        entiies = new Dictionary<string, GameObject>();
    }

    public bool TryGetEntity(string name, out GameObject entity) {
        return entiies.TryGetValue(name, out entity);
    }

}