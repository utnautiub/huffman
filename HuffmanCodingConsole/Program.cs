using HuffmanCodingConsole;
Console.OutputEncoding = System.Text.Encoding.UTF8;
string input = "Hellooo!";

Console.WriteLine("Input text: " + input);

HuffmanCoding huffman = new HuffmanCoding();
string encode = huffman.Encode(input);
string decode = huffman.Decode(encode);

Console.WriteLine("Danh sách kí tự kèm tần suất và từ mã: ");

foreach (char c in huffman.Symbols)
{
    Console.Write(c.ToString());
    Console.Write(" " + huffman.GetFrequency(c).ToString());
    Console.WriteLine(" " + huffman.GetCodeword(c).ToString());
}

Console.WriteLine("Encode text: " + encode);
Console.WriteLine("Decode text: " + decode);

Console.ReadLine();