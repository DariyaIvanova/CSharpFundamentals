


namespace _555.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Piece> allPieces = new Dictionary<string, Piece>();

            string input = string.Empty;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[]pieces = input.Split("|").ToArray(); 
                string name=pieces[0];
                string composer=pieces[1];
                string key = pieces[2];

                if (!allPieces.ContainsKey(name))
                {
                    Piece currentPiece = new Piece(name, composer, key);
                    allPieces.Add(name, currentPiece);
                }
            }

            while ((input=Console.ReadLine())!="Stop")
            {
                string[] commands = input.Split("|").ToArray();
                string command=commands[0];
                string piece=commands[1];

                switch (command)
                {
                    case "Add":
                        string composer=commands[2];
                        string key=commands[3];
                        AddMethod(allPieces, piece, composer, key);
                        break;

                    case "Remove":
                        RemoveMethod(allPieces, piece);
                        break;

                    case "ChangeKey":
                        string newKey=commands[2];
                        ChangeKeyMethod(allPieces, piece, newKey);
                        break;
                }
            }

            foreach (Piece piece in allPieces.Values)
            {
                Console.WriteLine($"{piece.PieceName} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }

        private static void ChangeKeyMethod(Dictionary<string, Piece> allPieces, string piece, string newKey)
        {
            if (!allPieces.ContainsKey(piece))
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                return;
            }
            allPieces[piece].Key= newKey;
            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
        }

        private static void RemoveMethod(Dictionary<string, Piece> allPieces, string piece)
        {
            if (!allPieces.ContainsKey(piece))
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                return;
            }
            allPieces.Remove(piece);
            Console.WriteLine($"Successfully removed {piece}!");
        }

        private static void AddMethod(Dictionary<string, Piece> allPieces, string piece, string composer, string key)
        {
            if (!allPieces.ContainsKey(piece))
            {
                allPieces[piece] = new Piece(piece, composer, key);
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                return;
            }
            Console.WriteLine($"{piece} is already in the collection!");
        }
    }
    public class Piece
    {
        public Piece(string pieceName, string composer, string key)
        {
            PieceName = pieceName;
            Composer = composer;
            Key = key;
        }

        public string PieceName { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

    }
}
