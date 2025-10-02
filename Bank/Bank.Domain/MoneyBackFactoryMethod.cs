namespace Bank.Domain
{
    /// <summary>
    /// Fábrica concreta para crear tarjetas MoneyBack.
    /// </summary>
    public class MoneyBackFactoryMethod : CreditCardFactoryMethod
    {
    /// <summary>
    /// Crea una instancia de MoneyBack.
    /// </summary>
    /// <returns>Instancia de MoneyBack.</returns>
    protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}