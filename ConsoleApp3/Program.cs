string str = "eedARBtVrolsiesuAoReerles";

int squareLength = Convert.ToInt32(Math.Sqrt(str.Length));

char[,] poemTurn = new char[squareLength, squareLength];

char[] ch = str.ToCharArray();

int count=0;

Console.WriteLine("Encrypted Message: "+str);


for(int rows = 0; rows < squareLength; rows++)
{
    for (int cols = 0; cols < squareLength; cols++)
    {

        poemTurn[rows, cols] = ch[count];
        count++;
    }
}

char[] decrypt= new char[squareLength*squareLength];
int secondCount=squareLength*squareLength;

for(int rows = 0; rows < squareLength; rows++)
{
    for(int cols = squareLength - 1; cols >= 0; cols--)
    {
        decrypt[secondCount-1] = poemTurn[cols,rows];
        secondCount--;
    }
}

Console.Write("Decrypted Message: ");
Console.WriteLine(decrypt);









