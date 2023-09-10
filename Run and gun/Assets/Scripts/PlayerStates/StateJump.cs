using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class StateJump : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController)
        {
            if (!_playerController) {
                _playerController = playerController;
            }
            if (playerController.grounded)
            {
                transform.Translate(Vector3.up * _playerController.maxSpeed *_playerController.jumpMod);
                playerController.grounded = false;
            }
        }
    }
}
