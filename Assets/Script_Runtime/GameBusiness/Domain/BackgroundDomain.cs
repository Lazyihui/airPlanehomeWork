using System;
using UnityEngine;


public static class BackgroundDomain {
    public static BackgroundEntity Spawn(GameContext ctx,Vector3 pos) {
        BackgroundEntity entity = GameFactory.Background_Create(ctx,pos);
        ctx.backgroundRespository.Add(entity);
        return entity;

    }

    public static void Move(BackgroundEntity bg, float dt) {
        bg.Move(dt);
    }

}