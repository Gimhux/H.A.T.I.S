using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;



namespace H.A.T.I.S
{
    class hatis
    {
        public Vector2 position = new Vector2(0, 0);
        private Texture2D vaisseau;
        public Rectangle size;
        public float scale = 1.0f;
        public KeyboardState kb;
       
        
    
    //Il faudrait coder les attributs des sprites mais j'y connais rien.//
    
        

        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {

            vaisseau = theContentManager.Load<Texture2D>(theAssetName);
           
            size = new Rectangle(0, 0,400 ,800);
        }

        //On charge le sprite en appellant la méthode à chaque nouveau sprite et on lui associe un nom dans "theAssetName".//
        //La variable size sert pour les backgrounds.//
        //J'arrive pas trop à régler la taille du bg.//


        public void Update(GameTime gameTime , Vector2 position)
        {
            
           
 
            
        }

        //RIEN//

        public void motion()
        {
            kb = Keyboard.GetState();

            if (kb.IsKeyDown(Keys.Up))
            {
                position.Y -= 5;
            }
            else if (kb.IsKeyDown(Keys.Down))
            {
                position.Y += 5;
            }
            else  if (kb.IsKeyDown(Keys.Left))
            {
                position.X -= 5;
            }
            else if (kb.IsKeyDown(Keys.Right))
            {
                position.X += 5;
            }
        }

        //Déplacement codé à l'arrache.Il faudrait utiliser une variable pour le nombre d'unités de déplacement mais ça se code dans les attributs, je crois...//

        public void Draw(SpriteBatch theSpriteBatch)
        {

            theSpriteBatch.Draw(vaisseau, position, Color.White);

        }
        //On dessine nos sprites.//


    }
}
