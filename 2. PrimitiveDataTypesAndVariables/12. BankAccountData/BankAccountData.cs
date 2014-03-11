/* A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers
 * associated with the account. Declare the variables needed to keep the
 * information for a single bank account using the appropriate data types
 * and descriptive names. */

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Pesho";
        string middleName = "Petrov";
        string lastName = "Petrov";
        decimal balance = 354.56M;
        string bankName = "Expressbank";
        string iban = "GR16 0110 1250 0000 0001 2300 695";
        long firstCardNum = 7539517569541236;
        long secondCardNum = 987654357951258;
        long thirdCardNum = 268742852369741;
    }
}