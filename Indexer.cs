class MyCollection
{
    private string[] data = new string[10];

    public string this[int index]
    {
        get { return data[index]; }
        set { data[index] = value; }
    }
}
