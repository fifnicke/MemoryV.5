using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;

namespace MemoryV._5
{
    public class SoundController
    {
        

        public void matchSound()
        {
            SoundPlayer player = new SoundPlayer("../../sounds/match.wav");
            player.Load();
            player.Play();
        }


        public void popSound()
        {
            SoundPlayer player = new SoundPlayer("../../sounds/pop.wav");
            player.Load();
            player.Play();
        }

        public void flipSound()
        {
            SoundPlayer player = new SoundPlayer("../../sounds/flipCard.wav");
            player.Load();
            player.Play();
        }

        public void gameOverSound()
        {
            SoundPlayer player = new SoundPlayer("../../sounds/GameOver.wav");
            player.Load();
            player.Play();
        }

        public void winSound()
        {            
            SoundPlayer player = new SoundPlayer("../../sounds/Win.wav");
            player.Load();
            player.Play();
        }
        

        public void Play(SoundType soundType)
        {
            
        }
    }
}
