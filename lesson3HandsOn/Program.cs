string[] seenThem = { "Emily", "Harry", "Rupert", "Clara", "Lily", "Michael", };

for (int i = 0; i < seenThem.Length; i++)
{
    Console.WriteLine("Have you seen" + ' ' + seenThem[i]+ "?");
}


for ( int i = seenThem.Length - 1; i >= 0; i-- )
{
    Console.WriteLine("Have you seen" + ' ' + seenThem[i]+ "?");
}
