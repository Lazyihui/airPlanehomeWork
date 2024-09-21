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

    public static BackgroundEntity Background_Create(GameContext ctx, Vector3 pos) {
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
        entity.rocketSpawnTimer = 1.0f;


        entity.id = ctx.gameEntity.playerIDRecord++;
        return entity;
    }

    public static RocketEntity Rocket_Create(GameContext ctx, Vector3 pos) {
        bool has = ctx.assetsContext.entiies.TryGetValue("RocketEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("RocketEntity prefab not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        RocketEntity entity = go.GetComponent<RocketEntity>();

        entity.Ctor();
        entity.SetPos(pos);

        entity.id = ctx.gameEntity.rocketIDRecord++;
        return entity;
    }


    public static MstEntity Mst_Create(GameContext ctx) {
        bool has = ctx.assetsContext.entiies.TryGetValue("MstEntity", out GameObject prefab);
        if (!has) {
            Debug.LogError("MstEntity prefab not found");
            return null;
        }

        GameObject go = GameObject.Instantiate(prefab);
        MstEntity entity = go.GetComponent<MstEntity>();

        entity.Ctor();
        entity.id = ctx.gameEntity.mstIDRecord++;

        return entity;
    }
}