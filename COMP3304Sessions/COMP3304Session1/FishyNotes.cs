using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304Session1
{
    public partial class FishyNotes : Form
    {
        //CREATE List called FishyNoteList of Type FishyNote
        List<FishyNote> _FishyNoteList;

        public FishyNotes()
        {
            InitializeComponent();

            //INITIALISE FishyNoteList
            _FishyNoteList = new List<FishyNote>();
        }

        //ON Click Event
        //CREATE new FishyNote instance in FishyNoteList
        //SHOW last created FishyNoteList index
        private void AddNote_Click(object sender, EventArgs e)
        {
            _FishyNoteList.Add(new FishyNote());

            _FishyNoteList[_FishyNoteList.Count - 1].Show();
        }
    }
}
