using System;

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
        NewData += listener;
    }

    private void ChangeText(String newText)
    {
        OnNewData(newText);
    }

}
