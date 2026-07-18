class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, int capacity, Address address) : base ("Big Cool Conference", "A super big and super cool conference for everyone who wants to become better", "11/12/2026", "1:00 PM", address)
    {
        _speaker = speaker;
        _capacity = capacity;   
    }
}