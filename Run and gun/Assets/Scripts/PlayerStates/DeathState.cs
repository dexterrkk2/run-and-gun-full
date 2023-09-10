using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Chapter.State
{
    public class DeathState : MonoBehaviour, IPlayerState
    {
        private PlayerController _playerController;
        public void Handle(PlayerController playerController)
        {
            if (!_playerController)
            {
                _playerController = playerController;
            }
            _playerController.GameOverUi.SetActive(true);
            Invoke("Restart", playerController.standingTimer);
        }
        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
