using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace H.A.T.I.S
{


    class Ennemy
    {
        private Texture2D ennemy;
        public Vector2 position;

        public void initialize()
        {

        }


        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {

            ennemy = theContentManager.Load<Texture2D>(theAssetName);

            
        }

        static void motion()
        {


        }








    }
}
