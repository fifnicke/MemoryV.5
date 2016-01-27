﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows;

namespace MemoryV._5
{
    public class SoundController
    {
        //private static SoundPlayer flipSound = new SoundPlayer();
        //private static SoundPlayer matchSound = new SoundPlayer();
        //private static SoundPlayer winSound = new SoundPlayer();
        //private static SoundPlayer gameOverSound = new SoundPlayer();
        //private static SoundPlayer popSound = new SoundPlayer();

        //private Dictionary<SoundType, SoundPlayer> soundPlayerDic = new Dictionary<SoundType, SoundPlayer>()
        //{
        //    {SoundType.Flip, flipSound},
        //    {SoundType.Match, matchSound},
        //    {SoundType.Win, winSound},
        //    {SoundType.GameOver, gameOverSound},
        //    {SoundType.Pop, popSound},
        //};

        public void matchSound()
        {
            SoundPlayer player = new SoundPlayer(@"pack://application:,,,/sounds/match.wav");
            player.Load();
            player.Play();
        }


        public void popSound()
        {
            SoundPlayer player = new SoundPlayer(@"pack://application:,,,/sounds/pop.wav");
            player.Load();
            player.Play();
        }

        public void flipSound()
        {
            SoundPlayer player = new SoundPlayer(@"pack://application:,,,/sounds/flipCard.wav");
            player.Load();
            player.Play();
        }

        public void gameOverSound()
        {
            SoundPlayer player = new SoundPlayer(@"pack://application:,,,/sounds/GameOver.wav");
            player.Load();
            player.Play();
        }

        public void winSound()
        {
            SoundPlayer player = new SoundPlayer(@"pack://application:,,,/sounds/Win.wav");
            player.Load();
            player.Play();
        }
        public SoundController()
        {
            //flipSound.Stream = Application.GetResourceStream(new Uri("../../sounds/flipCard.wav", UriKind.Relative)).Stream;
            //flipSound.Load();

            //matchSound.Stream = Application.GetResourceStream(new Uri("../../sounds/match.wav", UriKind.Relative)).Stream;
            //matchSound.Load();

            //winSound.Stream = Application.GetResourceStream(new Uri("../../sounds/Win.wav", UriKind.Relative)).Stream;
            //winSound.Load();

            //gameOverSound.Stream = Application.GetResourceStream(new Uri("../../sounds/GameOver.wav", UriKind.Relative)).Stream;
            //gameOverSound.Load();

            //popSound.Stream = Application.GetResourceStream(new Uri("../../sounds/pop.wav", UriKind.Relative)).Stream;
            //popSound.Load();
        }

        public void Play(SoundType soundType)
        {
            //soundPlayerDic[soundType].Play();
        }
    }
}
