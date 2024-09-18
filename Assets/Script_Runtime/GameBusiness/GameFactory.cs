using System;
using UnityEngine;



public static class GameFactory {

    public static MapEntity Map_Create(GameContext ctx) {
        bool has = ctx.assetsContext.entiies.TryGetValue("MapEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("MapEntity prefab not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        MapEntity entity = go.GetComponent<MapEntity>();

        entity.id = ctx.gameEntity.mapIDRecord++;

        return entity;
    }

    public static BackgroundEntity Background_Create(GameContext ctx,Vector3 pos) {
        bool has = ctx.assetsContext.entiies.TryGetValue("BackgroundEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("BackgroundEntity prefab not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        BackgroundEntity entity = go.GetComponent<BackgroundEntity>();

        entity.Ctor();
        entity.SetPos(pos);


        entity.id = ctx.gameEntity.backgroundIDRecord++;
        return entity;
    }

    public static PlayerEntity Player_Create(GameContext ctx) {
        bool has = ctx.assetsContext.entiies.TryGetValue("PlayerEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("PlayerEntity prefab not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        PlayerEntity entity = go.GetComponent<PlayerEntity>();

        entity.Ctor();

        entity.id = ctx.gameEntity.playerIDRecord++;
        return entity;
    }   


}