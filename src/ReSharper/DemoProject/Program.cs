using Silk.NET.Input;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using System;
using System.Drawing;
using Silk.NET.Maths;

namespace Tutorial
{
    class Program
    {
        private static IWindow window;
        private static GL Gl;

        private static uint Vbo;
        private static uint Ebo;
        private static uint Vao;
        private static uint Shader;

        //Vertex shaders are run on each vertex.
        private static readonly string VertexShaderSource = @"
        #version 330 core //Using version GLSL version 3.3
        layout (location = 0) in vec4 vPos;
        
        void main()
        {
            gl_Position = vec4(vPos.x, vPos.y, vPos.z, 1.0);
        }
        ";

        //Fragment shaders are run on each fragment/pixel of the geometry.
        private static readonly string FragmentShaderSource = @"
        #version 330 core
        out vec4 FragColor;

        void main()
        {
            FragColor = vec4(1.0f, 0.5f, 0.2f, 1.0f);
        }
        ";

        //Vertex data, uploaded to the VBO.
        private static readonly float[] Vertices =
        {
            //X    Y      Z
             0.5f,  0.5f, 0.0f,
             0.5f, -0.5f, 0.0f,
            -0.5f, -0.5f, 0.0f,
            -0.5f,  0.5f, 0.5f
        };

        //Index data, uploaded to the EBO.
        private static readonly uint[] Indices =
        {
            0, 1, 3,
            1, 2, 3
        };


        private static void Main(string[] args)
        {
            var options = WindowOptions.Default;
            options.Size = new Vector2D<int>(800, 600);
            options.Title = "LearnOpenGL with Silk.NET";
            window = Window.Create(options);

            window.Load += OnLoad;
            // window.Render += OnRender;
            // window.Update += OnUpdate;
            // window.Closing += OnClose;

            window.Run();
        }


        private static unsafe void OnLoad()
        {
            // IInputContext input = window.CreateInput();
            // for (int i = 0; i < input.Keyboards.Count; i++)
            // {
            //     input.Keyboards[i].KeyDown += KeyDown;
            // }

            //Getting the opengl api for drawing to the screen.
            Gl = GL.GetApi(window);
            
            fixed (float* vertices = Vertices)
            {
                Gl.BufferData(
                    GLEnum.ArrayBuffer,
                    (nuint) (Vertices.Length * sizeof(float)),
                    vertices,
                    GLEnum.StaticDraw);
            }

            Gl.BufferData(GLEnum.ArrayBuffer, (nuint) (Vertices.Length * sizeof(float)), in Vertices[0], GLEnum.StaticDraw);
            //
            // //Creating a vertex array.
            // Vao = Gl.GenVertexArray();
            // Gl.BindVertexArray(Vao);
            //
            // //Initializing a vertex buffer that holds the vertex data.
            // Vbo = Gl.GenBuffer(); //Creating the buffer.
            // Gl.BindBuffer(BufferTargetARB.ArrayBuffer, Vbo); //Binding the buffer.
            // fixed (void* v = &Vertices[0])
            // {
            //     Gl.BufferData(BufferTargetARB.ArrayBuffer, (nuint) (Vertices.Length * sizeof(uint)), v, BufferUsageARB.StaticDraw); //Setting buffer data.
            // }
            //
            // //Initializing a element buffer that holds the index data.
            // Ebo = Gl.GenBuffer(); //Creating the buffer.
            // Gl.BindBuffer(BufferTargetARB.ElementArrayBuffer, Ebo); //Binding the buffer.
            // fixed (void* i = &Indices[0])
            // {
            //     Gl.BufferData(BufferTargetARB.ElementArrayBuffer, (nuint) (Indices.Length * sizeof(uint)), i, BufferUsageARB.StaticDraw); //Setting buffer data.
            // }
            //
            // //Creating a vertex shader.
            // uint vertexShader = Gl.CreateShader(ShaderType.VertexShader);
            // Gl.ShaderSource(vertexShader, VertexShaderSource);
            // Gl.CompileShader(vertexShader);
            //
            // //Checking the shader for compilation errors.
            // string infoLog = Gl.GetShaderInfoLog(vertexShader);
            // if (!string.IsNullOrWhiteSpace(infoLog))
            // {
            //     Console.WriteLine($"Error compiling vertex shader {infoLog}");
            // }
            //
            // //Creating a fragment shader.
            // uint fragmentShader = Gl.CreateShader(ShaderType.FragmentShader);
            // Gl.ShaderSource(fragmentShader, FragmentShaderSource);
            // Gl.CompileShader(fragmentShader);
            //
            // //Checking the shader for compilation errors.
            // infoLog = Gl.GetShaderInfoLog(fragmentShader);
            // if (!string.IsNullOrWhiteSpace(infoLog))
            // {
            //     Console.WriteLine($"Error compiling fragment shader {infoLog}");
            // }
            //
            // //Combining the shaders under one shader program.
            // Shader = Gl.CreateProgram();
            // Gl.AttachShader(Shader, vertexShader);
            // Gl.AttachShader(Shader, fragmentShader);
            // Gl.LinkProgram(Shader);
            //
            // //Checking the linking for errors.
            // Gl.GetProgram(Shader, GLEnum.LinkStatus, out var status);
            // if (status == 0)
            // {
            //     Console.WriteLine($"Error linking shader {Gl.GetProgramInfoLog(Shader)}");
            // }
            //
            // //Delete the no longer useful individual shaders;
            // Gl.DetachShader(Shader, vertexShader);
            // Gl.DetachShader(Shader, fragmentShader);
            // Gl.DeleteShader(vertexShader);
            // Gl.DeleteShader(fragmentShader);
            //
            // //Tell opengl how to give the data to the shaders.
            // Gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), null);
            // Gl.EnableVertexAttribArray(0);
        }
        //
        // private static unsafe void OnRender(double obj) //Method needs to be unsafe due to draw elements.
        // {
        //     //Clear the color channel.
        //     Gl.Clear((uint) ClearBufferMask.ColorBufferBit);
        //
        //     //Bind the geometry and shader.
        //     Gl.BindVertexArray(Vao);
        //     Gl.UseProgram(Shader);
        //
        //     //Draw the geometry.
        //     Gl.DrawElements(PrimitiveType.Triangles, (uint) Indices.Length, DrawElementsType.UnsignedInt, null);
        // }
        //
        // private static void OnUpdate(double obj)
        // {
        //
        // }
        //
        // private static void OnClose()
        // {
        //     //Remember to delete the buffers.
        //     Gl.DeleteBuffer(Vbo);
        //     Gl.DeleteBuffer(Ebo);
        //     Gl.DeleteVertexArray(Vao);
        //     Gl.DeleteProgram(Shader);
        // }
        //
        // private static void KeyDown(IKeyboard arg1, Key arg2, int arg3)
        // {
        //     if (arg2 == Key.Escape)
        //     {
        //         window.Close();
        //     }
        // }
    }
}
