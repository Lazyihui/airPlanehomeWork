using System;
using UnityEngine;


public static class BackgroundDomain {
    public static BackgroundEntity Spawn(GameContext ctx) {
        BackgroundEntity entity = GameFactory.Background_Create(ctx);
        ctx.backgroundRespository.Add(entity);
        return entity;

    }

}