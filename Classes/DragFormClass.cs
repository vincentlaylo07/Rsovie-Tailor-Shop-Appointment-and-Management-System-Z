using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rsovie_Tailor_Shop_Appointment_and_Management_System_Z.Classes
{
    internal class DragFormClass
    {
        private Point mouseLocation;
        private Form formToDrag;

        public DragFormClass(Form form)
        {
            formToDrag = form;
            formToDrag.MouseDown += MouseDownMethod;
            formToDrag.MouseMove += MouseMoveMethod;
        }

        public void MouseDownMethod(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        public void MouseMoveMethod(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                formToDrag.Location = mousePose;
            }
        }
    }
}
