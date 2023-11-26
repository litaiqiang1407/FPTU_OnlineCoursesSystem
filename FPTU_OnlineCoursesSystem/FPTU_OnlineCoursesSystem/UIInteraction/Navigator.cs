namespace FPTU_OnlineCoursesSystem.UIInteraction
{
    public static class Navigator
    {
        // Open a child form in the specified panel
        public static void OpenChildForm(Form activeForm, Form childForm, Panel panel)
        {
            // Close the active form if it exists
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm; // Assign the child form as the active form

            // Set properties to make the child form suitable for a panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel.Controls.Add(childForm); // Add the child form to the panel           
            panel.Tag = childForm; // Set the Tag property of the panel to the child form object          
            childForm.BringToFront(); // Bring the child form to the front           
            childForm.Show(); // Show the child form
        }
    }
}
