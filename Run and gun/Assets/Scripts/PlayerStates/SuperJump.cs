using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class SuperJump : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }
            transform.Translate(Vector3.up * _playerController.maxSpeed * _playerController.jumpMod * 2);
            playerController.grounded = false;
        }
    }
}
