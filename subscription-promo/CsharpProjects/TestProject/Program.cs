Random random = new Random();
int daysUntilExpiration = random.Next(11);
int discountPercentage = 0;

// Your code goes here

// If zero days until expiration, print an empty line
if(daysUntilExpiration == 0)
{
  Console.WriteLine("");
}
// If one day until expiration, print a message about the discount percentage
else if(daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
}
// If five days or less until expiration, print a message about the discount percentage
else if(daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}
// if ten days or less until expiration, print a message about renewing the subscription
else if(daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}


