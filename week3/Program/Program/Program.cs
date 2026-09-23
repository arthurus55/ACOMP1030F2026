
/* STEP 1: DECLARATION statement for a string variable
* the keyword "string" tells the compiler the data type
* the variable name is called the IDENTIFIER
* the identifier can contain letters, digits, and underscores
* it must begin with a letter or underscore
* avoid using reserved keywords like "string"
*/

using System.Runtime.ConstrainedExecution;
using System.Xml;

string guest1Name;


/* STEP 2: ASSIGNMENT statement
 * the = symbol represents an assignment operation (not a comparison)
 * use double quotes ("") for the string value
 */

guest1Name = "Shivali";


/* STEP 3: Output the value of the variable using the WriteLine() method */

Console.WriteLine(guest1Name);


/* STEP 4: Assign a value to the variable at the same time it is declared */

string guest2Name = "Jacob";


/* STEP 5: Combine two strings using an EXPRESSION with two operands, and an operator */

string guessList = "Guest at the party includes: " + guest1Name + guest2Name;
Console.WriteLine(guessList);

/* STEP 6: Declare a variable to contain a WHOLE number
 * type short - has a range up to 32,767 (postive and negative)
 * type int - has a range up to 2,147,483,647 (postive and negative)
 * type long - has a range up to 9,223,372,036,854,775,807 (postive and negative)
 */

int MaxNumberGuests = 50;


/* STEP 7: Declare a variable to contain a REAL number
 * type float - stores numbers with maximum precision to 7 digits (1234567.0 to 0.1234567)
 * type double - stores numbers with 15 digits of precision (with over 300 digits)
 * type decimal - stores numbers with up to 28 digits of precision (but is limited to 28 digits)
 */

double partyExpenses = 245.54;


/* STEP 8: Performing calculations
 * Operator precedence is what you might expect
 * Consider the below:
 */
int a = 45;
int b = 50;
int c = a + b;
Console.WriteLine("The Output of addition of a + b is: " + c);

c = c * (a + b);
Console.WriteLine("The Output of addition of a + b is: " + c);
int d = a + b / a * b;
Console.WriteLine("The output of addition of a + b is: " + d);



int a1 = 30;
int b1 = 3;
Console.WriteLine(a1 / b1);

/* What will the final value of a, b, and c be after the following calculations? */




/* STEP 9: Converting numbers to text
 * In order to output a sentence describing the result of the above calculations,
 * we need to change the integers to strings - but if one of the operands on
 * either side of the + symbol is a number, C# automatically converts it to string.
 * Alternatively, we can use the ToString() method.
 */
string bText = b.ToString();
Console.WriteLine(bText + 10);

Console.WriteLine(bText + 10);

string x = "123";
int number = int.Parse(x);
Console.WriteLine(number);

/* STEP 10a: Precision and accuracy
 * Declare a variable of type int to hold the temperature in fahrenheit.
 * Declare another variable of type int to contain the above value in centigrade.
 * Note that the compiler complains about the second variable type...change it to double.
 */


int tempFahrenheit = 54;
double tempCelcius = (tempFahrenheit - 32) / 1.8;

Console.WriteLine(tempCelcius);

//int tempCelcius = (tempFahrenheit - 32) / 1.8;



// Take care not to confuse precision with accuracy


/* STEP 10b: Attempt to capture the temperature in centigrade as a type float. */
//float tempCelcius2 = (tempFahrenheit - 32) / 1.8;
/* Notice how it will not compile. The solution is casting.
 * Mismatched number types can be solved by telling the compiler that you know some
 * data loss may occur, but it won't really affect the program, so do it anyways.
 */

float tempCelcius2 = (float)( (tempFahrenheit - 32) / 1.8);
Console.WriteLine(tempCelcius2);

/* STEP 10c: Alternatively, cast the denominator in the above equation as a float,
 * and it will evaluate as a floating-point result.
 */

float tempCelcius3 = (tempFahrenheit - 32) / (float)1.8;
Console.WriteLine(tempCelcius3);


/* STEP 10d: Apply an even simpler method of casting an operand with a suffix. */

float tempCelcius4 = (tempFahrenheit - 32) / 1.8F;
Console.WriteLine(tempCelcius4);



/* Layout for a Grocery Receipt
 * Follow along with the instructor as we manipulate strings and numbers to visually
 * organize and output all the information required for a store receipt.
 */


/* String.Length
 * String.TrimStart|TrimEnd|Trim
 * String.Replace
 * String.ToUpper|ToLower
 * String.Contains
 * String.StartsWith|EndsWith
 * ToString()
 * 
 */


/* STEP 11: Declare and initialize all variables */

Console.Clear();
string item1 = "Milk";
double price1 = 6.99;

string item2 = "Eggs";
double price2 = 9.99;

string item3 = "Bread";
double price3 = 5.99;

string methodOfPayment = "debit";


/* STEP 12: The receipt layout is 30 characters in width. Create an empty line
 * of dots that will fill the space between the food item and the price. */


int receiptWidth = 30;
string dotLeader = new string('.', receiptWidth);
Console.WriteLine(dotLeader);
/* STEP 13a: To build a line, we need to know how many characters there are in
 * the item name, and the price. We will need to convert the price to a string. */

int item1NumChar = item1.Length;
string price1String = "$" + price1.ToString();
int price1NumChar = price1String.Length;

int item2NumChar = item2.Length;
string price2String = "$" + price2.ToString();
int price2NumChar = price2String.Length;

int item3NumChar = item3.Length;
string price3String = "$" + price3.ToString();
int price3NumChar = price3String.Length;


int line1NumsChar = item1NumChar + price1NumChar;
int line2NumsChar = item2NumChar + price2NumChar;
int line3NumsChar = item3NumChar + price3NumChar;



/* STEP 13b: Edit the dot leader string so that it is the correct length to fit
 * between the item string and the price. */
string line1DotLeader = dotLeader.Remove(0, line1NumsChar);

/* Test it out */

Console.WriteLine(line1DotLeader);

/* STEP 13c: Repeat the above code two more times for the other 2 grocery items */

string line2DotLeader = dotLeader.Remove(0, line2NumsChar);
string line3DotLeader = dotLeader.Remove(0, line3NumsChar);

/* STEP 14: Calculate the subtotal */
double subTotal = price1 + price2 + price3;


/* STEP 15: Calculate the tax */

double tax = subTotal * 0.13;
double Total = subTotal + tax;

/* STEP 16: Output the food items (include new line characters where needed) */

Console.Clear();
Console.WriteLine("Thank you for shopping at C#Mart");
Console.WriteLine($"{item1}{line1DotLeader}{price1String}");
Console.WriteLine($"{item2}{line2DotLeader}{price2String}");
Console.WriteLine($"{item3}{line3DotLeader}{price3String}");

/* STEP 17: Output the subtotal */

Console.WriteLine("------------------------------");
Console.WriteLine($"SUBTOTAL                 {subTotal}");

/* STEP 18: Output the tax - format it as a string with 2 decimal places */

Console.WriteLine($"TAX                      ${String.Format("{0:0.##}", tax)}");

/* STEP 19: Output the total of the receipt (also formatted with 2 decimal places */

Console.WriteLine($"TOTAL                   ${String.Format("{0:0.##}", Total)}");

/* STEP 20: Output the method of payment in ALL CAPS, and the amount paid */

Console.WriteLine("The method of Payment: " + methodOfPayment.ToUpper());

string finalPaymentMethod = methodOfPayment.ToUpper();

string Output = $"Payment Method: {finalPaymentMethod}, Amount Paid:${Total:0.##}";
Console.WriteLine(Output);