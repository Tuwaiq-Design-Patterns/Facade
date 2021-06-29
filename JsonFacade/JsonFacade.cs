using System;
using System.Collections.Generic;
using System.IO;


namespace JsonParserCSharp
{
    class JsonFacade
    {
        public static string ProvideJson(string sourceCode)
        {
            var input = File.ReadAllText($"{sourceCode}");
            Console.WriteLine($"input: {input}");
            Console.WriteLine();

            Tokenizer t = new Tokenizer(new Input(input), new Tokenizable[] {
                new WhiteSpaceTokenizer(),
                new NullTokenizer(),
                new NumberTokenizer(),
                new StringTokenizer(),
                new BoolTokenizer(),
                new SymbolTokenizer()
            });

            List<Token> tokens = t.all();

            Parser parser = new(tokens);
            parser.parse();
            return parser.ToString();
        }
    }
}