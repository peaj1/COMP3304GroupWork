﻿using System;
using System.Text;

interface ITextBoxStorage
{
    void LoadText(System.Windows.Forms.TextBox pTextBox);

    void Click(System.Windows.Forms.TextBox pTextBox);

    void TextChanged(System.Windows.Forms.TextBox pTextBox);
}
