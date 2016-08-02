using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Char;

namespace WindowsFormsApplication1
{
    internal struct PositioningFlags
    {
        public const uint SWP_ASYNCWINDOWPOS = 0x4000;
        public const uint SWP_DEFERERASE = 0x2000;
        public const uint SWP_DRAWFRAME = 0x20;
        public const uint SWP_FRAMECHANGED = 0x20;
        public const uint SWP_HIDEWINDOW = 0x80;
        public const uint SWP_NOACTIVATE = 0x10;
        public const uint SWP_NOCOPYBITS = 0x100;
        public const uint SWP_NOMOVE = 2;
        public const uint SWP_NOOWNERZORDER = 0x200;
        public const uint SWP_NOREDRAW = 8;
        public const uint SWP_NOREPOSITION = 0x200;
        public const uint SWP_NOSENDCHANGING = 0x400;
        public const uint SWP_NOSIZE = 1;
        public const uint SWP_NOZORDER = 4;
        public const uint SWP_SHOWWINDOW = 0x40;
    }

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int width, int height, uint uFlags);
        
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        
        private static int WM_SETREDRAW = 11;
        private Process[] _processList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            OnTick();
        }

        private void OnTick()
        {
            _processList = Process.GetProcessesByName(tbProcessName.Text);
            UpdateProcessCount(_processList.Length);
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            ResizeProcess(_processList);
        }

        private void ResizeProcess(IReadOnlyList<Process> processList)
        {
            var width = Convert.ToInt32(tbDefaultWidth.Text);
            var heigth = Convert.ToInt32(tbDefaultHeigth.Text);
            
            for (var i = 0; i < processList.Count(); i++)
            {
                SetWindowPos(processList[i].MainWindowHandle, Handle,
                    0, 0 + (i * 210), width, heigth,
                    PositioningFlags.SWP_NOSENDCHANGING);
            }
        }

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }

        private void UpdateProcessCount(int processCount)
        {
            labelProcessCount.Text = processCount.ToString();
        }

        private void HandleNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!IsControl(e.KeyChar) && !IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            var textBox = sender as TextBox;
            if (textBox != null && ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
            }
        }

        private void tbDefaultWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

        private void tbDefaultHeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleNumericInput(sender, e);
        }

    }
}
