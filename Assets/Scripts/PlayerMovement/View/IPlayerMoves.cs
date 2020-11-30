using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerMovement.View{
	
    public interface IPlayerMoves{
        void MoveInX(float actualMovementInX);
        void MoveInZ(float actualMovementInZ);
    }
}
