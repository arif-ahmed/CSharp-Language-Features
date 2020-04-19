# Object Communication and Events

#### Delegate in C#
<p>
A function can have one or more parameters of different data types, but what if you want to pass a function itself as a parameter? How does C# handle the callback functions or event handler? 
The answer is - <b>delegate</b>.
</p>

<p>
A delegate is like a pointer to a function. It is a reference type data type and it holds the reference of a method. 
All the delegates are implicitly derived from <code>System.Delegate</code> class.
</p>

```bash
<access modifier> delegate <return type> <delegate_name>(<parameters>)
```

```csharp
public delegate int SomeDelegate(int x, int y);
Func<int, bool> IsEvenDelegate;
Action<int> NumberAppender;

var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = numbers.Where(number => number % 2 == 0);
evenNumbers = numbers.Where(IsEven);

var evenNumbers = numbers.Where(number => number % 2 == 0);
evenNumbers = numbers.Where(IsEven);

IsEvenDelegate = IsEven;
evenNumbers = numbers.Where(IsEvenDelegate);

NumberAppender += Console.WriteLine;
NumberAppender += PrintNumber;
NumberAppender -= Console.WriteLine;

foreach (var evenNumber in evenNumbers)
{
  NumberAppender(evenNumber);
}

someDelegate = (x, y) =>
{
  return x * y;
};

someDelegate += delegate (int x, int y)
{
  return x + y;
};

someDelegate += someObject.SomeMethod;

static bool IsEven(int number)
{
  return number % 2 == 0;
}

static void PrintNumber(int number)
{
  Console.WriteLine($"Number: {number}");
}

static int Sum(int x, int y)
{
  return x + y;
}

static int Subtrack(int x, int y)
{
  return x - y;
}

static void DoWork(string message, Action<string> callback)
{
  Console.WriteLine($"Hello {message}");
  callback(message);
}
```

#### Built-in Delegate Types
* <b>Action</b> is a delegate type that describes a method that does not return a value. 
* <b>Func</b> is a delegate type that describes a method that returns a value.
* <b>EventHandler</b> public delegate void EventHandler(object sender, EventArgs e);
* <b>EventHandler<TEventArgs></b> public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);
