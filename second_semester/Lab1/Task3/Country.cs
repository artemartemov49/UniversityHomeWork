namespace Task3;

public class Country
{
    public string Name { get; }
    public string CountyCode { get; }

    public Country(string name, string countyCode)
    {
        Name = name;
        CountyCode = countyCode;
    }    
    
    public Country()
    {
        Name = "Default country";
        CountyCode = "DF";
    }
}