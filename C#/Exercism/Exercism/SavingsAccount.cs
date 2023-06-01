using System;

public static class SavingsAccount
{
    //Float f
    //double d
    //Decimal m

    public static float InterestRate(decimal balance)
    {
        if (balance < 0m)
            return 3.213f;
        else if (balance < 1000m)
            return 0.5f;
        else if (balance < 5000m)
            return 1.621f;
        else if (balance >= 5000m)
            return 2.475f;
        return 0f;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * ((decimal)InterestRate(balance)/100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + (Interest(balance));
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int cont = 1;
        decimal interest = Interest(balance);

        while (!((balance + interest) >= targetBalance))
        {
            balance += interest;
            interest = Interest(balance);
            cont++;
        };

        return cont;
    }
}
