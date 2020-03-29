using System;

namespace COMP3304Session1
{
    public class NoteData
    {
        public NoteData()
        {
        }

        public event EventHandler<myArgs> NewData;

        private void OnDataChanged(String data)
        {
            MyArgs args = new MyArgs(data);
            NewData(this, args);
        }

        public void Subscribe(EventHandler<MyArgs> listener)
        {
            //confused why we need to add equals listeners rather than just equals
            NewData += listener;
        }

        private void ChangeText(String newText)
        {
            OnNewData(newText); //test
        }

    }

}