namespace Bank.Domain
{
    /// <summary>
    /// Clase base para el patrón Factory Method de tarjetas de crédito.
    /// </summary>
    public abstract class CreditCardFactoryMethod
    {
    /// <summary>
    /// Método que debe implementar cada fábrica concreta para crear el producto.
    /// </summary>
    /// <returns>Instancia de ICreditCard.</returns>
    protected abstract ICreditCard MakeProduct();
        // Also note that The Creator's primary responsibility is not creating products. 
        // Usually, it contains some core business logic that relies on Product objects, returned by the factory method. 
    /// <summary>
    /// Crea y retorna el producto usando la fábrica concreta.
    /// </summary>
    /// <returns>Instancia de ICreditCard creada por la fábrica.</returns>
    public ICreditCard CreateProduct()
        {
            //Call the MakeProduct which will create and return the appropriate object 
            ICreditCard creditCard = this.MakeProduct();
            //Return the Object to the Client
            return creditCard;
        }
    }
}