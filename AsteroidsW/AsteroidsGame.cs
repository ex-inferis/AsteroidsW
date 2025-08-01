using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.Common;
using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace AsteroidsW;

public class AsteroidsGame : GameWindow
{
    public AsteroidsGame(GameWindowSettings gameSettings, NativeWindowSettings nativeSettings) : base(
        GameWindowSettings.Default, NativeWindowSettings.Default)
    {
        UpdateFrequency = GameConfig.TargetFPS;
    }

    protected override void OnLoad()
    {
        GL.ClearColor(0f, 0f, 0f, 1f); // Black background
    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        // Update game state, input, physics, etc.
        if (KeyboardState.IsKeyDown(Keys.Escape))
            Close();
    }

    protected override void OnRenderFrame(FrameEventArgs args)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        // Draw your stuff here
        SwapBuffers();
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        GL.Viewport(0, 0, Size.X, Size.Y);
    }

    protected override void OnUnload()
    {
        // Clean up
    }
}