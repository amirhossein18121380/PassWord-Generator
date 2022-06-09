namespace PassWord_Generator.ALL;

public class PassModel
{
    public bool? IsLowerCase { get; set; }
    public bool? IsUpperCase { get; set; }
    public bool? IsNumbers { get; set; }
    public bool? IsSymbols { get; set; }
    public bool? IsAmbiguous { get; set; }
    public int Length { get; set; }
}