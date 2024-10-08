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

    public static void PlayerToSpawnRocket(GameContext ctx, PlayerEntity player, float dt) {
        player.rocketSpawnTimer -= dt;
        if (ctx.moduleInput.isGetKeyDownSpace) {

            Debug.Log("player.rocketSpawnTimer:" + player.rocketSpawnTimer);

            if (player.rocketSpawnTimer <= 0) {
                RocketDomain.Spawn(ctx, player.transform.position);
                player.rocketSpawnTimer = 1;
                ctx.moduleInput.isGetKeyDownSpace = false;
            }


        }
    }
}