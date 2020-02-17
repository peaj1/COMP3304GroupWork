using System;
using System.Text;
namespace COMP3304Session1
{


    public interface ITextBoxStorage
    {
        void LoadText(System.Windows.Forms.TextBox pTextBox);

        void Click(System.Windows.Forms.TextBox pTextBox);

        void TextChanged(System.Windows.Forms.TextBox pTextBox);
    }

}