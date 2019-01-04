﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Myra;
using Myra.Graphics2D.UI;
using TittyPong.Contracts;
using TittyPong.Graphics;
using TittyPong.IO;
using TittyPong.UI;

namespace TittyPong.Core
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Master : Game
    {
        
        internal static Input IM { private set; get; }
        internal static Screen SM { private set; get; }
        internal static ContentManager Assets { private set; get; }
        internal static GameTime DeltaTime;

        internal IManager State;

        public Master()
        {
            Content.RootDirectory = "Content";
            Assets = Content;

            SM = new Screen();
            IM = new Input();

            SM.Init(this);
            IM.Init();
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            MyraEnvironment.Game = this;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            SM.LoadContent(Content);

            //Initialize starting state
            InitializeMenu();
        }

        protected override void UnloadContent()
        {
        }

        private void InitializeMenu()
        {
            State = new TittyMenu();
        }

        private void InitializeGame()
        {
            State = new TittyGame();
        }

        protected override void Update(GameTime gameTime)
        {
            IM.Update();
            DeltaTime = gameTime;
            State?.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            SM.Start();
            State?.Render();
            SM.Stop();
            base.Draw(gameTime);
        }
    }
}
