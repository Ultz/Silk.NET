using System;
using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace Tutorial_1._6___Hello_Gamepad
{
    class Program
    {
        private static IInputContext inputContext;
        private static IWindow window;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateWindow();
            window.Run();
        }

        private static void CreateWindow()
        {
            //Create a window.
            var options = WindowOptions.Default;
            options.Size = new Vector2D<int>(800, 600);
            options.Title = "Tutorial 1.6 - Hello Gamepad";

            window = Window.Create(options);

            //Assign events.
            window.Load += OnLoad;
            window.Update += OnUpdate;
            window.Render += OnRender;
        }
        private static void OnLoad()
        {
            //Set-up input context.
            inputContext = window.CreateInput();
            inputContext.ConnectionChanged += ConnectionChanged;

            for (int i = 0; i < inputContext.Keyboards.Count; i++)
            {
                inputContext.Keyboards[i].KeyDown += KeyDown;
            }

            //if a controller is plugged in before the application is launched, ConnectionChanged may or may not fire depending on the underlying driver used.
            RegisterGamepads();
        }

        private static void KeyDown(IKeyboard arg1, Key arg2, int arg3)
        {
            //Check to close the window on escape.
            if (arg2 == Key.Escape)
            {
                window.Close();
            }
        }

        private static void ConnectionChanged(IInputDevice arg0, bool arg1)
        {
            Console.WriteLine($"Input Connection Changed: {arg0.Name} {arg0.Index} isConnected: {arg1}");
            RegisterGamepads();
        }

        private static void RegisterGamepads()
        {
            for (int i = 0; i < inputContext.Gamepads.Count; i++)
            {
                inputContext.Gamepads[i].ButtonDown += ButtonDown;
                inputContext.Gamepads[i].ButtonUp += ButtonUp;
                inputContext.Gamepads[i].ThumbstickMoved += ThumbstickMoved;
                inputContext.Gamepads[i].TriggerMoved += TriggerMoved;
                inputContext.Gamepads[i].Deadzone = new Deadzone(0.05f, DeadzoneMethod.Traditional);
            }
        }

        private static void OnRender(double obj)
        {
            //Here all rendering should be done.
        }

        private static void OnUpdate(double obj)
        {
            //Here all updates to the program should be done.
        }
        private static void ThumbstickMoved(IGamepad arg1, Thumbstick arg2)
        {
            Console.WriteLine($"gamepad {arg1.Index} joystick {arg2.Index} moved to position {arg2.X},{arg2.Y}.");
        }
        private static void TriggerMoved(IGamepad arg1, Trigger arg2)
        {
            Console.WriteLine($"gamepad {arg1.Index} trigger {arg2.Index} moved to position {arg2.Position}.");
        }
        private static void ButtonDown(IGamepad arg1, Button arg2)
        {
            Console.WriteLine($"gamepad {arg1.Index} button down: {arg2.Index}.");
        }
        private static void ButtonUp(IGamepad arg1, Button arg2)
        {
            Console.WriteLine($"gamepad {arg1.Index} button up: {arg2.Index}.");
        }
    }
}
