using System;
using System.Numerics;

namespace Program
{
    class program
    {
       
        static void Main(string[] args)
        {
            string text = "void CreateGraphicalBoard()\r\n        {\r\n            for (int file = 0; file < 8; file++)\r\n            {\r\n                for (int rank = 0; rank < 8; rank++)\r\n                {\r\n                    bool isLightSquare = (file + rank) % 2 != 0;\r\n\r\n                    var squareColour = (isLightSquare) ? lightCol : darkCol;\r\n                    var position = new Vector2(-3.5f + file, -3.5f + rank);\r\n\r\n                    DrawSquare(squareColour, position);\r\n                }\r\n            }\r\n        }";
            StreamWriter print = new StreamWriter("File.txt", false);
            print.Write(text);
            print.Close();
            Console.WriteLine(text);
        }
    }
}
