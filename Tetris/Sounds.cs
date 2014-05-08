using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Sounds
    {
        private System.Media.SoundPlayer splashPlayer;
        private System.Media.SoundPlayer tapPlayer;
        private System.Media.SoundPlayer GameOverPlayer;
        private System.Media.SoundPlayer LevelUpPlayer;


        public Sounds() {
            splashPlayer = new System.Media.SoundPlayer();
            tapPlayer = new System.Media.SoundPlayer();
            GameOverPlayer = new System.Media.SoundPlayer();
            LevelUpPlayer = new System.Media.SoundPlayer();

            splashPlayer.Stream = Properties.Resources.Splat;
            GameOverPlayer.Stream = Properties.Resources.SadTrombone;
            LevelUpPlayer.Stream = Properties.Resources.LevelUp;
            tapPlayer.Stream = Properties.Resources.tapSound;
        }

        public void SplashPlay()
        {
            splashPlayer.Play();
        }
        public void GameOverSound()
        {
            GameOverPlayer.Play();
        }

        public void LevelUpSound()
        {
            LevelUpPlayer.Play();
        }

        public void TapSound() {
            tapPlayer.Play();
        }
    }
}
