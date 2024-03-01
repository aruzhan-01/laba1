using System.Text;
using System.Windows.Forms;
public class Lexeme
{
    public int Code { get; set; }
    public LexemeType Type { get; set; }
    public string Token { get; set; }
    public int StartPosition { get; set; }
    public int EndPosition { get; set; }

    public Lexeme(int code, LexemeType type, string input, int startPosition, int endPosition)
    {
        Code = code;
        Type = type;
        Token = input.Substring(startPosition, endPosition - startPosition + 1);
        StartPosition = startPosition;
        EndPosition = endPosition;
    }
}

public enum LexemeType
{

    Keyword1,
    Keyword2,
    DataType,
    Equally,
    Semicolon,
    Plus,
    Minus,
    Delimiter,
    Identifier,
    Number,
    True,
    False,
    Invalid
}

