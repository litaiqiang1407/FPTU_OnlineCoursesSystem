﻿namespace FPTU_OnlineCoursesSystem.UIInteraction
{
    // Button click event handlers class
    public static class ButtonClick
    {
        // Reset all comboboxes to default text
        public static void RefreshComboboxes(params ComboBox[] comboBoxes)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
                comboBox.Text = comboBox.AccessibleName;
            }
        }

        // Clear all inputs in a form
        public static void ClearAllInputs(string tableName, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (control is ComboBox comboBox)
                {
                    // Assuming the default text is set as the first item
                    comboBox.Text = comboBox.AccessibleName;
                }
                else if (control is Label label)
                {
                    // Special handling for valueID label
                    if (label.Name == "valueID")
                    {
                        label.Text = Helpers.GetNextID(tableName);
                    }
                    else
                    {
                        label.Text = string.Empty;
                    }
                }
            }
        }
    }

    // Button hover effects class
    public static class ButtonHover
    {
        // Apply hover effects to buttons not having special hover images
        public static void ApplyHoverEffects(Button[] buttons)
        {
            foreach (var button in buttons)
            {
                if (button.Name == "btnUpdate") {
                    button.BackColor = Color.FromArgb(100, 255, 109, 0);
                }

                if (button.Name == "btnDelete")
                {
                    button.BackColor = Color.FromArgb(100, 255, 109, 0);
                }               
                ApplyHoverEffect(button);
            }
        }

        // Apply hover effects to buttons having special hover images
        public static void ApplyHoverEffect(Button button, string normalImagePath = null, string hoverImagePath = null, bool specialButton = false)
        {
            button.Cursor = Cursors.Hand;
            // Event handler for mouse entering the button area
            button.MouseEnter += (sender, e) =>
            {
                // Change background image to hover image if provided
                if (!string.IsNullOrEmpty(hoverImagePath))
                {
                    button.BackgroundImage = Image.FromFile(hoverImagePath);
                }

                // Set text and background colors based on whether it's a special button
                button.ForeColor = specialButton ? Color.White : Color.FromArgb(255, 109, 0);
                button.BackColor = specialButton ? Color.FromArgb(255, 109, 0) : Color.White;

                // Draw a border around the button
                using (Graphics g = button.CreateGraphics())
                {
                    Color borderColor = specialButton ? Color.White : Color.FromArgb(255, 109, 0);
                    ControlPaint.DrawBorder(g, button.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
                }
            };

            // Event handler for mouse leaving the button area
            button.MouseLeave += (sender, e) =>
            {
                // Restore the normal background image if provided
                if (!string.IsNullOrEmpty(normalImagePath))
                {
                    button.BackgroundImage = Image.FromFile(normalImagePath);
                }

                // Reset text and background colors based on whether it's a special button
                button.ForeColor = specialButton ? Color.FromArgb(255, 109, 0) : Color.White;
                button.BackColor = specialButton ? Color.White : Color.FromArgb(255, 109, 0);

                // Redraw the border around the button
                using (Graphics g = button.CreateGraphics())
                {
                    Color borderColor = specialButton ? Color.White : Color.FromArgb(255, 109, 0);
                    ControlPaint.DrawBorder(g, button.ClientRectangle, borderColor, ButtonBorderStyle.Solid);
                }
            };
        }
    }

    // Cell click DataGridView event handler
    public static class CellClick
    {
        public static void DGVCellClick(object sender, DataGridViewCellEventArgs e, Control[] controls, string[] columnNames, Button[] buttons)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ((DataGridView)sender).Rows[e.RowIndex];

                if (row != null)
                {
                    foreach (var button in buttons)
                    {
                        button.Enabled = true;
                        button.Cursor = Cursors.Hand;
                        button.BackColor = Color.FromArgb(255, 109, 0);                      
                    }

                    for (int i = 0; i < controls.Length; i++)
                    {
                        string columnName = columnNames[i];

                        if (controls[i] is Label label)
                        {
                            label.Text = row.Cells[columnName].Value?.ToString();
                        }
                        else if (controls[i] is TextBox textBox)
                        {
                            textBox.Text = row.Cells[columnName].Value?.ToString();
                        }
                        else if (controls[i] is ComboBox comboBox)
                        {
                            // Get the cell value as a string
                            comboBox.Text = row.Cells[columnName].Value?.ToString();
                        }

                    }
                }
            }         
        }
    }   
}
