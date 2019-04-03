using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace NupskouProjectTheThird.Renderer
{
    public class Layer : AbstractLayer {

        private List <SpriteInstance> _sprites = new List <SpriteInstance> ();


        public override void Clear () {
            _sprites.Clear ();
        }


        public override void Render (SpriteBatch batch) {
            foreach (var sprite in _sprites) {
                sprite.Render (batch);
            }
        }


        public void Add (SpriteInstance sprite) {
            _sprites.Add (sprite);
        }


        public void Add (params SpriteInstance[] sprites) {
            _sprites.AddRange (sprites);
        }

    }
}