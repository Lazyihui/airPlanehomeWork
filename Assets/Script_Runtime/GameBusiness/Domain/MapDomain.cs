using System;
using UnityEngine;



public static class MapDomain {
    public static MapEntity Spawn(GameContext ctx) {
        MapEntity entity = GameFactory.Map_Create(ctx);
        ctx.mapRespository.Add(entity);
        return entity;

    }
}