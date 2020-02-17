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
        Dictionary<int, ITextBoxStorage> _textBoxDictionary;
       


        public FishyNotes()
        {
            InitializeComponent();

            //INITIALISE FishyNoteList & FishyNoteDictionary
            _FishyNoteList = new List<FishyNote>();
            _textBoxDictionary = new Dictionary<int, ITextBoxStorage>();
        
        }

        //ON Click Event
        //CREATE new FishyNote instance in FishyNoteList
        //SHOW last created FishyNoteList index
        private void AddNote_Click(object sender, EventArgs e)
        {
            _textBoxDictionary.Add(_FishyNoteList.Count, new TextBoxStorage());

            _FishyNoteList.Add(new FishyNote(RemoveNote, _FishyNoteList.Count, _textBoxDictionary[_FishyNoteList.Count]));

            _FishyNoteList[_FishyNoteList.Count - 1].Show();

        }

        private void RemoveNote(int id)
        {
            _FishyNoteList[id].Dispose();
            //POSSIBLE MEMORY PROBLEM
            //_FishyNoteList.RemoveAt(id);
        }
    }
}
