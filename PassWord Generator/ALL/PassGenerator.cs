namespace PassWord_Generator.ALL;

public class PassGenerator
{
    public static string CreatePassword(PassModel PassModel)
    {

        //bool IsLowerCase = false;
        //bool IsUpperCase = false;
        //bool IsNumbers = false;
        //bool IsSymbols = false;
        //bool IsAmbiguous = false;
        //int Length = 3;

        string MainResource = string.Empty;
        //List<string> MainResource = new List<string>();
        string UppervalidChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
        string LowervalidChars = "abcdefghijklmnopqrstuvwxyz";
        string Numbers = "0123456789";
        string Symbols = "!@#$%^&*?_+-";
        string Ambiguous = "/(){}[]<>";


        if (PassModel.IsLowerCase == true)
        {
            //MainResource.Add(LowervalidChars);
            MainResource += LowervalidChars;
            //MainResource.Concat(LowervalidChars);
        }
        if (PassModel.IsUpperCase == true)
        {
            //MainResource.Add(UppervalidChars);
            MainResource += UppervalidChars;
            //MainResource.Concat(UppervalidChars);
        }
        if (PassModel.IsNumbers == true)
        {
            //MainResource.Add(Numbers);
            MainResource += Numbers;
            //MainResource.Concat(Numbers);
        }
        if (PassModel.IsSymbols == true)
        {
            //MainResource.Add(Symbols);
            MainResource += Symbols;
            //MainResource.Concat(Symbols);
        }
        if (PassModel.IsAmbiguous == true)
        {
            //MainResource.Add(Ambiguous);
            MainResource += Ambiguous;
            //MainResource.Concat(Ambiguous);
        }

        //var charCount = MainResource.Select(x => x.Length).Sum();

        Random random = new Random();

        // Minimum size 3. Max size is number of all allowed chars.  
        //int size = random.Next(3, MainResource.Length);

        // Select one random character at a time from the string  
        // and create an array of chars  

        char[] chars = new char[PassModel.Length];
        for (int i = 0; i < PassModel.Length; i++)
        {
            //chars[i] = MainResource[i][random.Next(0, charCount)];
            chars[i] = MainResource[random.Next(0, MainResource.Length)];
        }
        return new string(chars);
    }
}