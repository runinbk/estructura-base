using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace estructura_base
{
    internal class Game : GameWindow

    {
        private float angle = 0.0f;
        private float angleHorizontal = 0.0f;
        private bool isMouseDown = false;
        private Vector2 lastMousePos;
        private float pitch = 0.0f;
        private float yaw = 0.0f;
        private float zoom = 2.0f;

        public Game(int width, int height, string title) 
            : base(GameWindowSettings.Default, new NativeWindowSettings() { Size = (width, height), Title = title })
        {
            VSync = VSyncMode.On;
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            base.OnUpdateFrame(e);

            if (KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }
        }

    }
}
