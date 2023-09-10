using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class DuckState : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }
            _playerController.isDiving = true;
            transform.localScale = new Vector3(2, .5f, 1);
        }
    }
}
