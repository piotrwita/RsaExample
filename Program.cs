using RsaExample;

RsaEncryption rsa = new RsaEncryption();
string cypher = string.Empty;

Console.WriteLine("Enter your text to encrypt");
var text = Console.ReadLine();  
if(!string.IsNullOrEmpty(text))
{
    cypher = rsa.Encrypt(text);
    Console.WriteLine($"Encrypted Text: {cypher}");
}

Console.WriteLine("Press any key to decrypt text");
Console.ReadLine();

var plainText = rsa.Decrypt(cypher);
Console.ReadLine();