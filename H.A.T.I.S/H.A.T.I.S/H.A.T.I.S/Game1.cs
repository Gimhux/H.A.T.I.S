using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace H.A.T.I.S
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        hatis hsprite;
        hatis hbg1;
        hatis hbg2;
        hatis hbg3;
        hatis hbg4;
        hatis hbg5;
        public int windowH;
        public int windowW;
        public KeyboardState clavier;
        
        //On déclare les sprites de backgrounds , des vaisseaux et l'état du clavier//

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

    //On initialise l'état du clavier et les sprites. On définit leur échelle.//
        protected override void Initialize()
        {
            
            windowH = Window.ClientBounds.Height;
            windowW = Window.ClientBounds.Height;
            clavier = Keyboard.GetState();

            hsprite = new hatis();



            hbg1 = new hatis();
            hbg1.scale = 2.0f;

            hbg2 = new hatis();
            hbg2.scale = 2.0f;

            hbg3 = new hatis();
            hbg3.scale = 2.0f;

            hbg4 = new hatis();
            hbg4.scale = 2.0f;

            hbg5 = new hatis();
            hbg5.scale = 2.0f;






            base.Initialize();


        }

        
        //Ici , on associe les images aux Sprites qu'on vient d'initialiser.On initialise leur position.//
        

        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);



            hsprite.LoadContent(this.Content, "mega");
            hsprite.position = new Vector2(125, 245);

            hbg1.LoadContent(this.Content, "Background01");
            hbg1.position = new Vector2(0, 0);

            hbg2.LoadContent(this.Content, "Background02");
            hbg2.position = new Vector2(hbg1.position.X + hbg1.size.Width, 0);

            hbg3.LoadContent(this.Content, "Background03");
            hbg3.position = new Vector2(hbg2.position.X + hbg2.size.Width, 0);

            hbg4.LoadContent(this.Content, "Background04");
            hbg4.position = new Vector2(hbg3.position.X + hbg3.size.Width, 0);

            hbg5.LoadContent(this.Content, "Background05");
            hbg5.position = new Vector2(hbg4.position.X + hbg4.size.Width, 0);

            
        }

        
        protected override void UnloadContent()
        {
          
        }
        //Pour l'instant on ne décharge rien.//
        
        protected override void Update(GameTime gameTime)
        {
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            hsprite.motion();

            if (hbg1.position.X < -hbg1.size.Width)
            {
                hbg1.position.X = hbg5.position.X + hbg5.size.Width;
            }
            if (hbg2.position.X < -hbg2.size.Width)
            {
                hbg2.position.X = hbg1.position.X + hbg1.size.Width;
            }
            if (hbg3.position.X < -hbg3.size.Width)
            {
                hbg3.position.X = hbg2.position.X + hbg2.size.Width;
            }
            if (hbg4.position.X < -hbg4.size.Width)
            {
                hbg4.position.X = hbg3.position.X + hbg3.size.Width;
            }
            if (hbg5.position.X < -hbg5.size.Width)
            {
                hbg5.position.X = hbg4.position.X + hbg4.size.Width;
            }

            
            Vector2 direction = new Vector2(-1, 0);
            Vector2 speed = new Vector2(160, 0);


            hbg1.position += direction * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            hbg2.position += direction * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            hbg3.position += direction * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            hbg4.position += direction * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            hbg5.position += direction * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

           
           

            base.Update(gameTime);
        }

      //Dans la méthode Update , on appelle les méthodes relatives aux Sprites(pour l'instant uniquement la méthode "motion" et on implémente le scrolling.//


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            
            hbg1.Draw(this.spriteBatch);
            hbg2.Draw(this.spriteBatch);
            hbg3.Draw(this.spriteBatch);
            hbg4.Draw(this.spriteBatch);
            hbg5.Draw(this.spriteBatch);
            hsprite.Draw(this.spriteBatch);
            spriteBatch.End();

          

            base.Draw(gameTime);
        }
        //On dessine les sprites (on appelle la méthode draw pour les sprites).//

    }
}
