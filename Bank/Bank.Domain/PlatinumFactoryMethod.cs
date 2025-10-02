namespace Bank.Domain
{
    /// <summary>
    /// Fábrica concreta para crear tarjetas Platinum.
    /// </summary>
    public class PlatinumFactoryMethod: CreditCardFactoryMethod
    {
    /// <summary>
    /// Crea una instancia de Platinum.
    /// </summary>
    /// <returns>Instancia de Platinum.</returns>
    protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}