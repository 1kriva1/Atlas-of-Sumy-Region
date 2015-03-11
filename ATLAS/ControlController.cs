using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    class ControlController
    {   
        Control controller;

        // Change visible 
        #region Visible
        public void VisibleOff(params object[] forms)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] is Control)
                {
                    controller = forms[i] as Control;
                    controller.Visible = false;
                }                
            }
        }

        public void VisibleOn(params object[] forms)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] is Control)
                {
                    controller = forms[i] as Control;
                    controller.Visible = true;
                }                
            }
        }

        public void VisibleChange(params object[] forms)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] is Control)
                {
                    controller = forms[i] as Control;
                    if (controller.Visible)
                        controller.Visible = false;
                    else
                        controller.Visible = true;
                }                
            }
        }
        #endregion

        // Change enabled
        #region Enabled
        public void EnableOff(params object[] forms)
        {            
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] is Control)
                {
                    controller = forms[i] as Control;
                    controller.Enabled = false;
                }                
            }
        }

        public void EnableOn(params object[] forms)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] is Control)
                {
                    controller = forms[i] as Control;
                    controller.Enabled = true;
                }                
            }
        }

        public void EnableChange(params object[] forms)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                if (forms[i] is Control)
                {
                    controller = forms[i] as Control;
                    if (controller.Enabled)
                        controller.Enabled = false;
                    else
                        controller.Enabled = true;
                }                
            }
        }
        #endregion

        // Change color
        #region Change color

        // Change color when mouse down
        public void ChangeColorMouseDown(object sender)
        {
            if (sender is Control)
            {
                controller = sender as Control;
                controller.BackColor = Color.Yellow; 
            }           
        }

        // Come back to previous color(White) when mouse up
        public void ChangeColorMouseUp(object sender)
        {
            if (sender is Control)
            {
                controller = sender as Control;
                controller.BackColor = Color.White;
            }            
        }
        #endregion

        // Change cursor's interface
        public static Cursor LoadCustomCursor(string path)
        {
            IntPtr hCurs = LoadCursorFromFile(path);
            if (hCurs == IntPtr.Zero) throw new Win32Exception();
            var curs = new Cursor(hCurs);
            // Note: force the cursor to own the handle so it gets released properly
            var fi = typeof(Cursor).GetField("ownHandle", BindingFlags.NonPublic | BindingFlags.Instance);
            fi.SetValue(curs, true);
            return curs;
        }
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr LoadCursorFromFile(string path);
    }
}
