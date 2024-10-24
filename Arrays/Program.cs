

Console.WriteLine("Hello, World!");

// Arrays
// Array Insertions & Deletions

/**--- Insert at end of Array ---**/
int[] inEnd = new int[6];

// make a variable to keep the length because Length is based of Capacity and does not track actual index
int length = 0;
// initial values
for (int i = 0; i < 3; i++)
{
    inEnd[length++] = i;
}
Console.WriteLine(string.Join(' ', inEnd));
inEnd[length] = 5;
length++;
Console.WriteLine(string.Join(' ', inEnd));
Console.WriteLine();



/**--- Insert at start of Array ---**/
int[] inStart = new int[6];
length = 0;
// initial values
for (int i = 0;i < 3; i++)
{
    inStart[length++] = i;
}
Console.WriteLine(string.Join(' ', inStart));

for (int i = length; i > 0 ; i--)
{
    // this is moving all the values
    inStart[i] = inStart[i - 1];
}
inStart[0] = 5;
Console.WriteLine(string.Join(' ', inStart));
Console.WriteLine();


/**--- Insert anywhere in array ---**/
int[] inAnywhere = new int[10];
length = 0;
// initial values
for (int i = 0; i < 7; i++)
{
    inAnywhere[length++] = i;
}
Console.WriteLine(string.Join(' ', inAnywhere));
int insertIndex = 4;
int valueToBeInserted = 100;
Console.WriteLine(string.Join(' ', InsertAnyWhere(inAnywhere, insertIndex, length, valueToBeInserted)));
Console.WriteLine();

int[] InsertAnyWhere(int[] arAnywhere, int insertIndex, int length, int valueToBeInserted)
{
    // Shifting the array to right
    for(int i = length; i > insertIndex; i--)
    {
        arAnywhere[i] = arAnywhere[i - 1];
    }

    arAnywhere[insertIndex] = valueToBeInserted;
    return arAnywhere;
}



/**--- Delete from end of array ---**/
int[] deEnd = new int[7];

// make a variable to keep the length because array.Length is based of Capacity and does not track actual index
length = 0;
// initial values
for (int i = 0; i < 5; i++)
{
    deEnd[length++] = i;
}
Console.WriteLine(string.Join(' ', deEnd));
//length--; // simple removes the last element in the array. logically delete the element, but it will there in memory
deEnd[--length] = 0; 
Console.WriteLine(string.Join(' ', deEnd));
Console.WriteLine();



/**--- Delete from start of array ---**/
int[] deStart = new int[7];
length = 0;
// initial values
for (int i = 0; i < 6; i++)
{
    deStart[length++] = i;
}
Console.WriteLine(string.Join(' ', deStart));
// shifting the left from end
for (int i = 1; i < length; i++)
{
    deStart[i - 1] = deStart[i];
}
deStart[--length] = 0;
Console.WriteLine(string.Join(' ', deStart));
Console.WriteLine();



/**--- Delete from anywhere in array ---**/
int[] deAnywhere = new int[10];
length = 0;
// initial values
for (int i = 0; i < 7; i++)
{
    deAnywhere[length++] = i;
}
Console.WriteLine(string.Join(' ', deAnywhere));

int deleteIndex = 4;
Console.WriteLine(string.Join(' ', DeleteAnyWhere(deAnywhere, deleteIndex, length)));

int[] DeleteAnyWhere(int[] deAnywhere, int deleteIndex, int length)
{
    // Shifting the array to left
    for (int i = deleteIndex; i < length; i++)
    {
        deAnywhere[i-1] = deAnywhere[i];
    }

    deAnywhere[--length] = 0;
    return deAnywhere;
}