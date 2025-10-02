namespace Bank.Domain
{
    /// <summary>
    /// Implementación de tarjeta Titanium.
    /// </summary>
    public class Titanium : ICreditCard
    {
    /// <summary>
    /// Devuelve el tipo de tarjeta Titanium.
    /// </summary>
    /// <returns>"Titanium Edge"</returns>
    public string GetCardType()
        {
            return "Titanium Edge";
        }
    /// <summary>
    /// Devuelve el límite de crédito para Titanium.
    /// </summary>
    /// <returns>Límite de crédito.</returns>
    public int GetCreditLimit()
        {
            return 25000;
        }
    /// <summary>
    /// Devuelve el cargo anual para Titanium.
    /// </summary>
    /// <returns>Cargo anual.</returns>
    public int GetAnnualCharge()
        {
            return 1500;
        }
    }
}