using System;
using UnityEngine;


public static class RocketDomain {
    public static RocketEntity Spawn(GameContext ctx, Vector3 pos) {
        RocketEntity entity = GameFactory.Rocket_Create(ctx, pos);
        ctx.rocketRespository.Add(entity);
        return entity;
    }


    public static void Move() { }
}