namespace BankEncapsulation;
public class BankAcccount
{
    public BankAcccount() {}

    private double balance = 0;

    public void Deposit( double amount )
    {
        balance += amount;
    }

    public string GetBalance()
    {
        return $"${balance}";
    }
}