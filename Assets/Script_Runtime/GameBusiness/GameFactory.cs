using System;
using UnityEngine;



public static class GameFactory {

    public static MapEntity Map_Create(GameContext ctx) {
        bool has = ctx.assetsContext.entiies.TryGetValue("MapEntity", out GameObject prefab);
        if(!has) {
            Debug.LogError("MapEntity prefab not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        MapEntity entity = go.GetComponent<MapEntity>();
        
        entity.id = ctx.gameEntity.mapIDRecord++;


        return entity;
    }

}