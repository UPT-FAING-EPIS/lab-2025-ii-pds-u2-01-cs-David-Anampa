namespace Bank.Domain
{
    /// <summary>
    /// Fábrica concreta para crear tarjetas Titanium.
    /// </summary>
    public class TitaniumFactoryMethod : CreditCardFactoryMethod
    {
    /// <summary>
    /// Crea una instancia de Titanium.
    /// </summary>
    /// <returns>Instancia de Titanium.</returns>
    protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}