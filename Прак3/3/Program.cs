class SQL_Dump
{
    public string CommandText { get; set; }
    public void ExecuteNonQuery() { }
    public static implicit operator SQL_Dump(string commandText)
    {
        return new SQL_Dump { CommandText = commandText };
    }
    public static implicit operator string(SQL_Dump command)
    {
        return command.CommandText;
    }
    public static implicit operator SQL_Dump(int commandText)
    {
        return new SQL_Dump { CommandText = commandText.ToString() };
    }
    public static implicit operator int(SQL_Dump command)
    {
        return int.Parse(command.CommandText);
    }
    public static implicit operator SQL_Dump(double commandText)
    {
        return new SQL_Dump { CommandText = commandText.ToString() };
    }
    public static implicit operator double(SQL_Dump command)
    {
        return double.Parse(command.CommandText);
    }
    static void Main()
    {
        SQL_Dump command = "SELECT * FROM Table";
        command.ExecuteNonQuery();
    }

}