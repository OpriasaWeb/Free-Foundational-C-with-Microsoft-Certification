
/* 

Code challenge: rewrite if-elseif-else using a switch statement
You'll start with code that uses an if-elseif-else construct to evaluate the components of a product SKU. The SKU (Stock Keeping Unit) is formatted using three coded values: <product #>-<2-letter color code>-<size code>. For example, a SKU value of 01-MN-L corresponds to (sweat shirt)-(maroon)-(large), and the code outputs a description that appears as "Product: Large Maroon Sweat shirt".

*/

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";
string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

for (int i = 0; i < product.Length; i++)
{
    switch (i)
    {
        case 0: // Product type
            type = product[i] switch
            {
                "01" => "Sweat shirt",
                "02" => "T-Shirt",
                "03" => "Sweat pants",
                _ => "Other"
            };
            break;
        
        case 1: // Color
            color = product[i] switch
            {
                "BL" => "Black",
                "MN" => "Maroon",
                _ => "White"
            };
            break;
        
        case 2: // Size
            size = product[i] switch
            {
                "S" => "Small",
                "M" => "Medium",
                "L" => "Large",
                _ => "One Size Fits All"
            };
            break;
    }
}

Console.WriteLine($"Product: {size} {color} {type}");
