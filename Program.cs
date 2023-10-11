// Create an empty list of type object
List<object> things = new List<object>();

// Add the following values to the list: 7, 28, -1, true, "chair"
things.Add(7);
things.Add(28);
things.Add(-1);
things.Add(true);
things.Add("chair");

int sum = 0;

// Loop through the list and print all values (Hint: Type Inference might help here!)
foreach (var thing in things)
{
    Console.WriteLine(thing);

    // Add all values that are Int type together and output the sum
    if (thing is int)
    {
        sum += (int)thing;
    }

}

Console.WriteLine(sum);