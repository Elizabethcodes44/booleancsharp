int employeeLevel = 201;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
    

}
Console.WriteLine($"{employeeName}, {title}");
//to assign multıple labels to a swıtch sectıon 
int employeeLevel2 = 200;
string employeeNames = "Adedapo";
string title2 = "";
switch (employeeLevel2)
{
    case 100:
    case 200:
        title2 = "Chairman";
        break;
    case 500:
        title2 = "Manager";
        break;
    default:
       title2 = "House2";
       break;

}
Console.WriteLine($"{employeeNames} {title2}");
//switch challenge
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";
switch (product[0])
{
    case "01":
       type = "sweatshirt";
       color = "Marroon";
       size = "large";
       break;
    case "02":
        type = "sweater";
        color = "red";
        size = "large";
        break;
    default:
        
        size = "One type fits all";
        break;
}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"{sku} {type} {color} {size}");