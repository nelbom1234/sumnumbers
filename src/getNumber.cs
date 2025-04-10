namespace sumtal;

public class Number {
    public static int GetNumber() {
        int tal;
        string? result;
        while (true) {
            System.Console.WriteLine("skriv et tal");
            result = Console.ReadLine();

            if (!int.TryParse(result, out tal)) {
                System.Console.WriteLine("Du skal give et gyldigt heltal. prøv igen");
                continue;
            }
            return tal;
        }
    }
}