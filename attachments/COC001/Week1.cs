//-------------------------------------------------------------------------------------------------
// Name input / output

string firstname;
string secondname;

Console.Write("Enter your first name: ");
firstname = Console.ReadLine();
Console.Write("Enter your second name: ");
secondname = Console.ReadLine();

Console.Write("Hello, {0} {1} ", firstname, secondname);
// But before the introduction of the {0} syntax they will have code more like this:
//Console.Write("Hello, ");
//Console.WriteLine(name);

Console.ReadLine();



//-------------------------------------------------------------------------------------------------
// Average of three heights

int userheight;
int neighbour1height;
int neighbour2height;

Console.Write("Enter your own height in cm: ");
userheight = int.Parse(Console.ReadLine());
Console.Write("Enter first neighbour's height in cm: ");
neighbour1height = int.Parse(Console.ReadLine());
Console.Write("Enter second neighbour's height in cm: ");
neighbour2height = int.Parse(Console.ReadLine());

// That's the shorthand method above, they will start with this (x3):
//string heightstring;
//heightstring = Console.ReadLine();
//userheight = int.Parse(heightstring);


int averageheight = (userheight + neighbour1height + neighbour2height) / 3;
Console.Write("Average height is {0}", averageheight);
            
Console.ReadLine();
 

//-------------------------------------------------------------------------------------------------
// Advanced material for stronger programmers
// Calulate average of three heights but entered and displayed as feet and inches

int userHeightFt;
int userHeightIn;
int height1Ft;
int height1In;
int height2Ft;
int height2In;

Console.WriteLine("Enter your own height");
Console.Write("Feet: ");
userHeightFt = int.Parse(Console.ReadLine());
Console.Write("Inches: ");
userHeightIn = int.Parse(Console.ReadLine());

Console.Write("Enter first neighbour's height");
Console.Write("Feet: ");
height1Ft = int.Parse(Console.ReadLine());
Console.Write("Inches: ");
height1In = int.Parse(Console.ReadLine());

Console.Write("Enter first neighbour's height");
Console.Write("Feet: ");
height2Ft = int.Parse(Console.ReadLine());
Console.Write("Inches: ");
height2In = int.Parse(Console.ReadLine());

int userHeight = userHeightFt * 12 + userHeightIn;
int height1    = height1Ft    * 12 + height1In;
int height2    = height2Ft    * 12 + height2In;

int averageHeight = (userHeight + height1 + height2) / 3;
// Those trying the second last exercise will also need the % operator, I've mentioned it but
// require a little initiative on the student's part. Expect to have to given help on this though
Console.Write("Average height is {0}'{1}\"", averageHeight / 12, averageHeight % 12);
            
Console.ReadLine();
