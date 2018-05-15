using SQLite4Unity3d;
public class Pump { 

    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Model { get; set; }
    public long Serial { get; set; }
    public string MadeIn { get; set; }

    public override string ToString()
    {
        return string.Format("[Pump: Id={0}, Model={1},  Serial={2}, MadeIn={3}]", Id, Model, Serial, MadeIn);
    }
}
