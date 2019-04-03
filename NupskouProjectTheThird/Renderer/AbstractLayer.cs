using Microsoft.Xna.Framework.Graphics;

namespace NupskouProjectTheThird.Renderer
{
    public abstract class AbstractLayer {


        public abstract void Clear ();

        public abstract void Render (SpriteBatch batch);

    }
}