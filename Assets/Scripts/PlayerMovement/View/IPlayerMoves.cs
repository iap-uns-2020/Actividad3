using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMovement.View
{
    public interface IPlayerMoves
    {
        void GetControlPlayerUpdate();
        void MoveInX(float actualMovementInX, float actualMovementInY);
        void MoveInZ(float actualMovementInZ, float actualMovementInY);
    }
}
