namespace AtmServices.Test;
using AtmServices;

public class AtmTests
{
    Atm testAtm;
    int initialBalance = 100;

    public AtmTests() {
        testAtm = new Atm(initialBalance);
    }

    [Fact]
    public void Test_Withdraw()
    {
        var result = testAtm.withdraw(25);
        Assert.True(result);
        Assert.Equal(75, testAtm.getBalance());

    }
    [Fact]

    public void Test_Withdraw_Failure_NotEnoughBalance()
    {
        var result = testAtm.withdraw(150); // greater than balance
        Assert.False(result);
        Assert.Equal(initialBalance, testAtm.getBalance());
    }

    [Fact]
    public void Test_Deposit_Success()
    {
        var result = testAtm.deposit(50);
        Assert.True(result);
        Assert.Equal(initialBalance + 50, testAtm.getBalance());
    }

    [Fact]
    public void Test_Deposit_Failure_NegativeAmount()
    {
        var result = testAtm.deposit(-10);
        Assert.False(result);
        Assert.Equal(initialBalance, testAtm.getBalance());
    }

    [Fact]
    public void Test_GetBalance_ReturnsCurrent()
    {
        Assert.Equal(initialBalance, testAtm.getBalance());
    }




}
