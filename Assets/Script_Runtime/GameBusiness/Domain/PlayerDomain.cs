using System;
using UnityEngine;


public static class PlayerDomain {


    public static PlayerEntity Spawn(GameContext ctx) {
        PlayerEntity entity = GameFactory.Player_Create(ctx);

        ctx.playerRespository.Add(entity);
        return entity;
    }

    public static void Move(GameContext ctx, PlayerEntity player, Vector3 moveAxis, float dt) {
        player.Move(moveAxis, dt);
    }
}