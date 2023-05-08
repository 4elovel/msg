using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SimpleProject
{
    public class DllImportExample
    {
        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern int MessageBoxA(IntPtr hWnd, string text, string caption, uint type);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            DllImportExample.MessageBoxA(IntPtr.Zero, "Повідомлення у форматі Unicode успішно виведено", "Повідомлення", 0);
        }
    }
}